using System.Collections;
using System.Reflection;
using UnityEngine;
using UnityEngine.Networking;

namespace Common.Coroutines
{
    internal class EditorCoroutine
    {
        private readonly IEnumerator _coroutine;

        private object _current;

        private EditorCoroutine _subroutine;

        public object Current
        {
            get => _current;
        }

        public EditorCoroutine(IEnumerator coroutine)
        {
            _coroutine = coroutine;
        }

        public bool MoveNext()
        {
            if (_subroutine != null)
            {
                if (!_subroutine.MoveNext())
                {
                    _subroutine = null;
                }
                else
                {
                    return true;
                }
            }

            if (_coroutine.MoveNext())
            {
                _current = _coroutine.Current;

                if (_current is IEnumerator enumerator)
                {
                    _subroutine = new EditorCoroutine(enumerator);
                }
                else if (_current is WaitForSeconds waitForSeconds)
                {
                    var field = waitForSeconds.GetType().GetField("m_Seconds", BindingFlags.NonPublic | BindingFlags.Instance);
                    if (field != null)
                    {
                        var seconds = (float)field.GetValue(waitForSeconds);
                        var subroutine = Yield.Time(seconds);
                        _subroutine = new EditorCoroutine(subroutine);
                    }
                }
                else if (_current is WaitForSecondsRealtime waitForSecondsRealtime)
                {
                    var subroutine = Yield.Realtime(waitForSecondsRealtime.waitTime);
                    _subroutine = new EditorCoroutine(subroutine);
                }
                else if (_current is UnityWebRequest unityWebRequest)
                {
                    var subroutine = Yield.Await(() => unityWebRequest.isDone);
                    _subroutine = new EditorCoroutine(subroutine);
                }
                else if (_current is AsyncOperation asyncOperation)
                {
                    var subroutine = Yield.Await(() => asyncOperation.isDone);
                    _subroutine = new EditorCoroutine(subroutine);
                }
                else if (_current is CustomYieldInstruction customYieldInstruction)
                {
                    var subroutine = Yield.Await(customYieldInstruction.MoveNext);
                    _subroutine = new EditorCoroutine(subroutine);
                }

                if (_subroutine != null)
                {
                    if (!_subroutine.MoveNext())
                    {
                        _subroutine = null;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
