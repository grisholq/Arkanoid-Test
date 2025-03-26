using System;
using UnityEngine;
using VContainer;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    public float SpeedMultiplyer { get; set; } = 1;
    private float Speed => gameConfig.BallSpeed;
    
    [Inject] private GameConfig gameConfig;
    [Inject] private Rigidbody2D rigidbody;

    private void Start()
    {
        SetMovementDirection(Vector2.down);
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = rigidbody.velocity.normalized * (SpeedMultiplyer * Speed);
    }

    public void SetMovementDirection(Vector2 direction)
    {
        _rigidbody.velocity = direction * Speed * SpeedMultiplyer;
    }

    public void RandomizeMovementDirection()
    {
        Vector2 direction = _rigidbody.velocity;
        direction += Random.insideUnitCircle * 0.1f;
        direction = direction.normalized;
        SetMovementDirection(direction);
    }

    public void ForceSetMovementDirectionAfterCollision(Vector2 direction)
    {
        SetMovementDirection(direction);   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // RandomizeMovementDirection();
    }
}