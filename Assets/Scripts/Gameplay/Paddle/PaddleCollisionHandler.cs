using System;
using UnityEngine;

public class PaddleCollisionHandler : MonoBehaviour
{
    public event Action<Collision2D, Ball> BallHit;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Ball ball))
        {
            BallHit?.Invoke(other, ball);
        }
    }
}
