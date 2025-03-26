using UnityEngine;

public class PaddleMouseInput : IPaddleInput
{    
    public Vector3 Position => _camera.ScreenToWorldPoint(Input.mousePosition);
    public bool Pressed => Input.GetMouseButton(0);
    
    private readonly Camera _camera;

    public PaddleMouseInput(Camera camera)
    {
        _camera = camera;
    }
}