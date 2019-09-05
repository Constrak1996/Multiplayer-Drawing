using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class GameObject
    {
        public Vector2 spriteCenter;
        public Texture2D Sprite;

        public GameObject(Vector2 pos, Vector2 mousePos, Texture2D sprite)
        {
            
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

        }
    }
    
    
}
