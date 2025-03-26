using UnityEngine;
using VContainer;
using VContainer.Unity;

public class BallScope : LifetimeScope
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private Ball ball;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(mainTransform);
        builder.RegisterComponent(rigidbody2D);
        builder.RegisterComponent(ball);
    }
}