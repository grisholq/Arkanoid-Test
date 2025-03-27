using System;
using System.Collections.Generic;
using UnityEngine;

public class BrickHealth
{
    public int Current 
    {
        get => current;
        set
        {
            current = value;

            if(current <= 0)
            {
                OutOfHealth?.Invoke();
            }
        }
    }

    public event Action OutOfHealth;

    [Serializable]
    public class Settings
    {
        public int Health;
    }

    private int current = 0;

    public BrickHealth(Settings settings)
    {
        Current = settings.Health; 
    }

    public void Damage(int damage)
    {
        Current -= damage;
    }
}