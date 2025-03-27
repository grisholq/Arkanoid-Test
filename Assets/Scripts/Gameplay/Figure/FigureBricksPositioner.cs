using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureBricksPositioner
{
    public class Settings
       {
        public Transform UpperStartPoint;
    }

    private Settings settings;

    public FigureBricksPositioner(Settings settings, IObjectResolver objectResolver)
    {
        this.settings = settings;
    }

    public void PositionRow(BricksRow bricksRow)
    {
        foreach(var brick in bricksRow.Bricks)
        {

        }
    }
}