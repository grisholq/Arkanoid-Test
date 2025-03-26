using System;
using System.Collections.Generic;
using UnityEngine;

public class PaddleWidth
{
    [Serializable]
    public class Settings
    {
        public List<WidthData> Sizes;
    }

    public struct WidthData
    {
        public Transform LeftBorder, RightBorder;
        public Vector3 Scale;
        public WidthType Width;
    }

    public enum WidthType
    {
        Normal = 0,
        Wide = 1
    }
}
