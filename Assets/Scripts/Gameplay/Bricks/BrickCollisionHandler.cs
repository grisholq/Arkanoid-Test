using System;
using System.Collections.Generic;
using UnityEngine;

public class BrickCollisionHandler : MonoBehaviour
{
    public event Action<Ball> BallHit;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.TryGetComponent(out Ball ball))
        {
            BallHit?.Invoke(ball);
        }
    }
}
