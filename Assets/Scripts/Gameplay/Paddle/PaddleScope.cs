using UnityEngine;
using VContainer;
using VContainer.Unity;

public class PaddleScope : LifetimeScope
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private Paddle paddle;
    [SerializeField] private PaddleCollisionHandler paddleCollisionHandler;
    [SerializeField] private PaddleMovementBorders.Settings paddleBordersSettings;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(mainTransform);
        builder.RegisterComponent(paddle);
        builder.RegisterComponent(paddleCollisionHandler);
        builder.RegisterComponent(paddleBordersSettings); 
        builder.Register<PaddleMovementBorders>(Lifetime.Scoped).AsSelf().AsImplementedInterfaces();
        builder.Register<PaddleBallHitter>(Lifetime.Scoped).AsSelf().AsImplementedInterfaces();
    }
}