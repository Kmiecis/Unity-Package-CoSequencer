# CoSequencer

## Description

Create your single or sequenced animations followed by actions or custom tasks with ease using highly optimized and precise coroutine sequencer.  
Schedule and control them with many custom made methods.  

There is no manager class or additional scripts required, only good ol' coroutines, down to the very core.  
This means that there is no initialization needed and all sequences behave exactly as any handmade coroutine would.

## Introduction

Have you ever wondered how task sequencing can be done easily by using Unity Coroutines? Well, you can wonder no more!  
This package is a successful attempt to utilize one of the most widely known feature of Unity and yet one that, in my opinion, is mostly underrated, due to its bad press.  
By default, it should be used to ease creating sequences of actions, but also features some cool built-in methods, commonly known from other similar sequencers.  
Two things make it stands out in the sequencers field: it behaves just like Coroutines would (obviously) and it is packagable, which means it does not require any initialization. Just install and get the job done.  

## Installation

Add the package via Package Manager by adding it from git URL:  
`https://github.com/Kmiecis/Unity-Package-CoSequencer.git`  

For more information about how it can be done, visit [Unity website](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

OR

Git add this repository as a submodule inside your Unity project Assets folder:  
`git submodule add https://github.com/Kmiecis/Unity-Package-CoSequencer`  

## Examples

Sample copy and paste examples, ready to go, to give a taste of how the code might look.

<details>
<summary>
Moving and rotating platform
</summary>
<p>

```cs
using UnityEngine;
using Common.Coroutines;

namespace Common.Examples
{
    public class LiftBehaviour : MonoBehaviour
    {
        public Vector3 liftOffset = Vector3.up;
        public float liftDuration = 2.0f;
        public float holdDuration = 2.0f;

        private void Lift()
        {
            Vector3 liftPosition = transform.position + liftOffset; // Lift target position
            Quaternion liftRotation = transform.localRotation * Quaternion.AngleAxis(180.0f, Vector3.up); // Lift target rotation

            transform.CoMove(liftPosition, liftDuration) // Moves platform to target position
                .With(transform.CoLocalRotate(liftRotation, liftDuration)) // Rotates platform to target rotation while platform is moving
                .WaitTime(holdDuration) // Waits a certain amount of time
                .Then(
                    transform.CoMove(transform.position, liftDuration), // Moves platform to its original position
                    transform.CoLocalRotate(transform.localRotation, liftDuration) // Rotates platform to its original rotation while platform is moving
                )
                .WaitTime(holdDuration) // Waits a certain amount of time
                .Then(Lift) // Invokes itself again to schedule another run
                .Start(this); // Starts coroutine on current MonoBehaviour
        }

        private void Start()
        {
            Lift();
        }
    }
}
```

</p>
</details>

<details>
<summary>
Doors opening when a target transform is in close proximity
</summary>
<p>

```cs
using UnityEngine;
using Common.Coroutines;

namespace Common.Examples
{
    public class DoorBehaviour : MonoBehaviour
    {
        public Transform targetTransform;

        public float openDistance = 2.0f;
        public float openDuration = 2.0f;
        public float closeDuration = 2.0f;
        public float holdDuration = 1.0f;

        private Quaternion _startRotation;
        private Quaternion _targetRotation;

        private bool IsCloseEnough()
        {
            return (targetTransform.position - transform.position).magnitude <= openDistance;
        }

        private bool IsFarEnough()
        {
            return !IsCloseEnough();
        }

        private void OpenMechanism()
        {
            UCoroutine.YieldAwait(IsCloseEnough) // Sequence awaits target to be close enough to run
                .Then(transform.CoRotate(_targetRotation, openDuration)) // Rotates door to target rotation
                .WaitTime(holdDuration) // Waits a certain amount of time before continuing
                .Await(IsFarEnough) // Sequence awaits target to be far enough to continue
                .Then(transform.CoRotate(_startRotation, closeDuration)) // Rotates door to its original rotation
                .WaitTime(holdDuration) // Waits a certain amount of time before continuing
                .Then(OpenMechanism) // Invokes itself to schedule another run
                .Start(this); // Starts coroutine on current MonoBehaviour
        }

        private void Awake()
        {
            _startRotation = transform.rotation;
            _targetRotation = _startRotation * Quaternion.AngleAxis(90.0f, Vector3.up);
        }

        private void Start()
        {
            OpenMechanism();
        }
    }
}
```

</p>
</details>

<details>
<summary>
Button bounces and fades out when clicked
</summary>
<p>

```cs
using UnityEngine;
using Common.Coroutines;
using UnityEngine.UI;

namespace Common.Examples
{
    public class ButtonBehaviour : MonoBehaviour
    {
        public Button button;
        public CanvasGroup canvasGroup;

        public float bounceScale = 1.3f;
        public float bounceDuration = 1.0f;
        public float fadeDuration = 0.33f;

        private Coroutine _bounceCoroutine;

        private void Bounce()
        {
            _bounceCoroutine = transform.CoLocalScale(transform.localScale * bounceScale, bounceDuration) // Scale up over duration
                .Then(transform.CoLocalScale(transform.localScale, bounceDuration)) // Scale down over duration
                .Then(Bounce) // Invokes itself to schedule another run
                .Start(this); // Starts coroutine on current MonoBehaviour and saves Coroutine to a variable for later use
        }

        private void FadeOut()
        {
            _bounceCoroutine.Stop(this); // Stops saved bouncing Coroutine
            canvasGroup.CoFade(0.0f, fadeDuration) // Fades out every graphic under CanvasGroup component
                .With(transform.CoLocalScale(transform.localScale * bounceScale, fadeDuration)) // Scales up while fading
                .Start(this); // Starts coroutine on current MonoBehaviour
        }

        private void Awake()
        {
            button.onClick.AddListener(FadeOut);
        }

        private void Start()
        {
            Bounce();
        }
    }
}
```

</p>
</details>
