using UnityEngine;

public interface IPaddleInput
{
    public Vector3 Position { get; }
    public bool Pressed { get; }
}
