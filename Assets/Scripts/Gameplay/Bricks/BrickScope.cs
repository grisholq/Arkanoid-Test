using UnityEngine;
using VContainer;
using VContainer.Unity;

public class BrickScope : LifetimeScope
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private Brick brick;
    [SerializeField] private BrickCollisionHandler brickCollisionHandler;
    [SerializeField] private BrickHealth.Settings settings;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(mainTransform);
        builder.RegisterComponent(brick).AsSelf().AsImplementedInterfaces();
        builder.RegisterComponent(brickCollisionHandler);
        builder.RegisterInstance(settings);
        builder.Register<BrickHealth>(Lifetime.Scoped);
    }
}