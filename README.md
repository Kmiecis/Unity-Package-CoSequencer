# Coroutines

## Description

Common scripts that assist in managing Coroutines

## Introduction

Have you ever wondered how task sequencing can be done by using Unity Coroutines? Well, wonder no more!  
This package is an attempt to utilize one of the most widely known feature of Unity and yet one that, in my opinion, is mostly underrated, due to its bad press.  
By default, it should be used to ease creating sequences of actions, but also features some cool built-in methods, commonly known from other similar sequencers.  

## Examples

Under the hood, there is no manager class that handles the sequences. It is all coroutines, down to the core!  
Which means that we have to be aware that building a sequence works top-down and by default it merges previously built coroutine into new one.  
As a result, two example methods found below will have a different outcome.  

```cs
void ExampleMethod1()
{
    UCoroutine.Yield()
        .Wait(1.0f) // Waits 1 second
        .Then(Move(1.0f)) // Moves for 1 second
        .With(Scale(1.0f)) // Scales for 1 second while we are waiting
        .Start(this);
}

void ExampleMethod2()
{
    UCoroutine.Yield()
        .Wait(1.0f) // Waits 1 second
        .Then(
            Move(1.0f) // Moves for 1 second
                .With(Scale(1.0f)) // Scales for 1 second while we are moving
        )
        .Start(this);
}
```

<details>
<summary>
Creating and starting a sequence
</summary>
<p>

To create a sequence, we have to start with an IEnumerator, which can be an arbitrary method or one of many provided with the package.  
To start a sequence, we have to call Start(...) extension method, with a MonoBehaviour as an argument.  

```cs
IEnumerator Move()
{
...
}

IEnumerator Scale()
{
...
}

void ExampleCreateAndStartWithAnyMethod()
{
    Move()
        .Wait(1.0f)
        .Then(Scale)
        .Start(this);
}

void ExampleCreateAndStartWithBuiltInMethod()
{
    UCoroutine.Yield()
        .Then(Move)
        .Wait(1.0f)
        .Then(Scale)
        .Start(this);
}


```

</p>
</details>

<details>
<summary>
Stopping a sequence
</summary>
<p>

Just to be clear, sequences by themselves <b><i>DO NOT</i></b> require arbitrary stopping mechanism. They finish by themselves, just as any ordinary coroutine.  
To stop a sequence, we have to cache it ourselves and call Stop(...) extension method on it, with a target MonoBehaviour as an argument.  

```cs
private Coroutine _example;

void ExampleStartSequence()
{
    _example = Move().Start(this);
}

void ExampleStopSequence()
{
    _example.Stop(this);
}
```

</p>
</details>

<details>
<summary>
Using object manipulation extensions
</summary>
<p>

There are many methods to create an object changing sequence. Below few will be found. For more it would be advisable to check the code yourself.  

#### An infinitely moving platform, up and down:  

```cs
void StartMovePlatform()
{
    var height = 2.0f;
    var time = 2.0f;
    transform.CoMoveY(transform.position.y + height, time)
        .Then(transform.CoMoveY(transform.position.y, time))
        .Then(StartMovePlatform)
        .Start(this);
}
```

#### A door opening method with automated closing system when target is far enough:  

```cs
private bool IsFarEnough()
{
    ...
}

void OpenDoor()
{
    var duration = 3.0f;
    transform.CoRotate(Quaternion.AngleAxis(90.0f, Vector3.up), duration)
        .Wait(duration)
        .Await(IsFarEnough)
        .Then(transform.CoRotate(Quaternion.identity, duration))
        .Start(this);
}
```

#### A button scale & fade animation with callback on finish:  

```cs
void OnClick(Action onFinish)
{
    canvasGroup.CoFade(0.0f, duration, EEase.Linear.ToEaser())
        .With(transform.CoLocalScale(Vector3.one * 1.3f, duration, EaseMath.InBounce))
        .Then(onFinish)
        .Start(this);
}
```

</p>
</details>

## Installation

Add the package via Package Manager by adding it from git URL:  
`https://github.com/kmiecis/unity-package-coroutines.git`  
Package Manager can be found inside the Unity Editor in the Window tab

OR

Git add this repository as a submodule inside your Unity project Assets folder:  
`git submodule add https://github.com/Kmiecis/Unity-Package-Coroutines`
