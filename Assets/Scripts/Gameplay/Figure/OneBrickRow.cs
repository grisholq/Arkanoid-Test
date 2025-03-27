using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

    [Serializable]
    [CreateAssetMenu(menuName = "Figure/OneBrickRow")]
    public class OneBrickRow : BricksRow
    {
        public override IEnumerable<Brick> Bricks => Enumerable.Repeat(Brick, Amount);
        public int Amount;
        public Brick Brick;
    }