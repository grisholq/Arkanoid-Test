using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameScope : LifetimeScope
{
    [SerializeField] private GameConfig gameConfig;
    
    [SerializeField] private Ball ball;
    [SerializeField] private Paddle paddle;
    [SerializeField] private Camera camera;
    [SerializeField] private FigureData _defaultFigure;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(gameConfig);
        
        builder.RegisterInstance(ball);
        builder.RegisterInstance(paddle);
        builder.RegisterComponent(camera);
        
        builder.Register<PaddleMouseInput>(Lifetime.Scoped).AsImplementedInterfaces();

        builder.Register<GameStateMachine>(Lifetime.Scoped).AsSelf().AsImplementedInterfaces();
        builder.Register<PlayState>(Lifetime.Scoped).AsSelf().AsImplementedInterfaces();
    }
}