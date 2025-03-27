using System;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using DG.Tweening;

public class Brick : MonoBehaviour, IInitializable, IDisposable
{
    [Inject] private BrickCollisionHandler brickCollisinoHandler;
    [Inject] private BrickHealth health;
    [Inject] private Transform transform;

    public event Action<Brick> Died;

    public void Initialize()
    {
        brickCollisinoHandler.BallHit += HandleBallHit;
        health.OutOfHealth += Die;
    }

    private void HandleBallHit(Ball ball)
    {
        Debug.Log(1);
        health.Damage(ball.Damage);
    }

    public void Dispose()
    {
        brickCollisinoHandler.BallHit -= HandleBallHit;
        health.OutOfHealth -= Die;
    }

    public void Die()
    {
        Died?.Invoke(this);
        Destroy(gameObject);
    }
}