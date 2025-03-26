using System;
using UnityEngine;
using VContainer.Unity;

public class PaddleMovementBorders : IInitializable
{
   [Serializable]
    public class Settings
    {
        public Transform LeftBorder, RightBorder;
    }

    private Vector3 leftPosition, rightPosition;

    private Settings settings;

    public PaddleMovementBorders(Settings settings)
    {
        this.settings = settings;
    }

    public void Initialize()
    {
        leftPosition = settings.LeftBorder.position;
        rightPosition = settings.RightBorder.position;
    }
    
    public bool PositionInsideBorders(Vector3 position)
    {
        return position.y == leftPosition.y &&
               position.z == leftPosition.z && 
               position.x >= leftPosition.x && 
               position.x <= rightPosition.x;
    }

    public Vector3 AdjustPosition(Vector3 position)
    {
        position.y = leftPosition.y;
        position.z = leftPosition.z;
        position.x = Mathf.Clamp(position.x, leftPosition.x, rightPosition.x);
        return position;
    }
}