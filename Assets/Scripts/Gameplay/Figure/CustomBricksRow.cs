using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

    [Serializable]
    [CreateAssetMenu(menuName = "Figure/CustomRow")]
    public class CustomBricksRow : BricksRow
    {
        public override IEnumerable<Brick> Bricks => BricksList;
        public List<Brick> BricksList;
    }
