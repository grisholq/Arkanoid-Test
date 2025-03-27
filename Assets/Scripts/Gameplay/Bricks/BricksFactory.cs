using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksFactory
{
    private IObjectsResolver objectsResolver;

    public BricksFactory(IObjectsResolver objectsResolver)
    {
        this.objectsResolver = objectsResolver;
    }

    public IEnumerable<Brick> CreateRow(BricskRow bricskRow)
    {
        List<Brick> bricks = new List<Brick>();
        
        foreach
    }
}
