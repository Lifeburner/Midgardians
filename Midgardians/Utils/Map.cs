using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Midgardians.Utils
{
    public struct Overlay
    {
        public static Texture2D fogTx, snowTx, undergroundTx;
        public Rectangle destRectTopL, destRectTopR, destRectBtmL, destRectBtmR,
                         srcRectTopL, srcRectTopR, srcRectBtmL, srcRectBtmR;
        public Vector2 velocity;
        public bool isScrolling;
    }

    public class Map : Main
    {
        public static Rectangle mapScrnSourceRect, mapView;

        public static Rectangle[] mapRectArray = new Rectangle[]
        {
            new Rectangle(520, 303, 281, 222),
            new Rectangle(520, 303, 281, 222)
        };

        public static Vector2 scaleFactor;

        public Rectangle mapScrRect;
        public Vector2 drawPos;
        public int mapPosX, mapPosY, depth;
        public string name;
        public string trader; // This should've been of type Monster.
        public List<string> questNPCs; // This should've been of type QuestNPC.
        public string questNPC; // This should've been of type QuestNPC.
    }
}
