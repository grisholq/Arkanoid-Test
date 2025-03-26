using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;

public class Paddle : MonoBehaviour
{
    [Inject] private Transform mainTransform;
    [Inject] private PaddleMovementBorders paddleMovementBorders;
    
    public void SetPosition(Vector3 position)
    {
        if (paddleMovementBorders.PositionInsideBorders(position) == false)
        {
            position = paddleMovementBorders.AdjustPosition(position);
        }
        mainTransform.position = position;
    }
}