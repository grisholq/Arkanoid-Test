    using System.Collections.Generic;
    using UnityEngine;
    
    public abstract class BricksRow : ScriptableObject
    {
        public abstract IEnumerable<Brick> Bricks {get;}
    }