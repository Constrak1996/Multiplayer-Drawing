using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class BlackPixel : GameObject
    {
        MouseState mouse;
        

        public BlackPixel(int posX, int posY, string sprite) : base(posX, posY, sprite)
        {
            
        }

        public override void Update()
        {
            if (mouse.LeftButton == ButtonState.Pressed)
            {
                
            }

            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

    }
}
