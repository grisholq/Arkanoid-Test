using System;
using UnityEngine;
using VContainer.Unity;

public class PaddleBallHitter : IInitializable, IDisposable
{
    private PaddleCollisionHandler paddleCollisionHandler;
    private Transform mainTransform;
    
    public PaddleBallHitter(PaddleCollisionHandler paddleCollisionHandler, Transform mainTransform)
    {
        this.paddleCollisionHandler = paddleCollisionHandler;
        this.mainTransform = mainTransform;
    }
    
    public void Initialize()
    {
        paddleCollisionHandler.BallHit += HandleBallHit;
    }
    
    private void HandleBallHit(Collision2D collision, Ball ball)
    {
        if (BallHitUpperSide(collision, ball) == false) return;
        
        var direction = CalculateBallBounceDirection(collision, ball);
        ball.ForceSetMovementDirectionAfterCollision(direction);
    }

    private Vector2 CalculateBallBounceDirection(Collision2D collision, Ball ball)
    {
        float ballX = ball.transform.position.x;
        float paddleX = mainTransform.position.x;
        float paddleWidth = mainTransform.localScale.x;

        float relativeBallPosition = ballX - paddleX;
        float minPaddleX = paddleX - paddleWidth / 2;
        float maxPaddleX = paddleX + paddleWidth / 2;
        
        float bounceLerpValue = MathUtility.Remap(relativeBallPosition, minPaddleX, maxPaddleX, 0, 1);
        float bounceAngle = Mathf.Lerp(140, 40, bounceLerpValue);
        float bounceAngleRad = bounceAngle * Mathf.Deg2Rad;
        
        return new Vector2(Mathf.Cos(bounceAngleRad), Mathf.Sin(bounceAngleRad));
    }

    private bool BallHitUpperSide(Collision2D collision, Ball ball)
    {
        ContactPoint2D contact = collision.GetContact(0);
        Vector2 normal = contact.normal;
        Vector2 hitPoint = contact.point;
        
        return normal.y < 0 && hitPoint.y >= mainTransform.position.y;
    }
    
    public void Dispose()
    {
        paddleCollisionHandler.BallHit -= HandleBallHit;
    }
}