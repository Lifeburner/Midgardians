using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Midgardians.Utils
{
    public class AnimatedTexture
    {
        private Texture2D _myTexture;
        private float _timePerFrame, _totalElapsed;
        private int _frameWidth;
        public int frameCount, frame;
        public float rotation, scale, depth;
        public string name;
        public Vector2 origin;

        public bool IsPaused { get; private set; }

        public AnimatedTexture(Vector2 origin, float rotation, float scale, float depth)
        {
            this.origin = origin;
            this.rotation = rotation;
            this.scale = scale;
            this.depth = depth;
        }

        public void Load(ContentManager content, string asset, int frameCount, int framesPerSec)
        {
            this.frameCount = frameCount;
            this._myTexture = content.Load<Texture2D>(asset);
            this._timePerFrame = 1f / framesPerSec;
            this.frame = 0;
            this._totalElapsed = 0;
            this.IsPaused = false;
            this._frameWidth = this._myTexture.Width / this.frameCount;
        }

        public void UpdateFrame(float elapsed)
        {
            if (this.IsPaused) return;
            this._totalElapsed += elapsed;

            if (this._totalElapsed > this._timePerFrame)
            {
                this.frame++;

                this.frame = this.frame % this.frameCount;
                this._totalElapsed -= this._timePerFrame;
            }
        }

        public void Reset()
        {
            this.frame = 0;
            this._totalElapsed = 0;
        }

        public void Stop()
        {
            this.Pause();
            this.Reset();
        }

        public void Play()
        {
            this.IsPaused = false;
        }

        public void Pause()
        {
            this.IsPaused = true;
        }
    }
}