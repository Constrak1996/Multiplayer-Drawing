using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class BlackPixel : GameObject
    {
        MouseState mouse;
        Texture2D sprite;
        Vector2 pos;
        Vector2 mousePos;
        private Texture2D Sprite;
        public static int cPosX;
        public static int cPosY;

        public BlackPixel(Vector2 pos, Vector2 mousePos, Texture2D sprite) : base(pos, mousePos, sprite)
        {
            mousePos = new Vector2(mouse.X, mouse.Y);
            this.Sprite = sprite;
            this.pos = pos;
        }

        public override void Update()
        {
            mouse = Mouse.GetState();
            cPosX = mouse.X;
            cPosY = mouse.Y;
            
            

            base.Update();
        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, pos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 1f);
            base.Draw(gametime, spriteBatch);
        }

    }
}
