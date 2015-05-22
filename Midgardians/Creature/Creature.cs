using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Midgardians.Creature
{
    public abstract class Creature
    {
        public Texture2D texture;
        public Color tint;
        public bool isVisible, isMoving;

        public string name;

        public Vector2 curPos, newCurPos, drawPos, newPos, absolutePos, startingPos, moveDir,
                       vel = new Vector2(8, 8);


    }
}
