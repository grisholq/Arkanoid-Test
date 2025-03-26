using UnityEngine;

public class PlayState : IState
{
    private readonly Paddle paddle;
    private readonly IPaddleInput paddleInput;
    private readonly Camera camera;
    private IStateMachine stateMachine;

    public PlayState(Paddle paddle, IPaddleInput paddleInput, Camera camera)
    {
        this.paddle = paddle;
        this.paddleInput = paddleInput;
        this.camera = camera;
    }

    public void Enter()
    {
    }

    public void Update()
    {
        HandlePaddleMovement();
    }

    private void HandlePaddleMovement()
    {
        if (paddleInput.Pressed)
        {
            paddle.SetPosition(paddleInput.Position); 
        }
    }

    public void FixedUpdate()
    {
    }

    public void Exit()
    {
    }

    public void SetStateMachine(IStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
}