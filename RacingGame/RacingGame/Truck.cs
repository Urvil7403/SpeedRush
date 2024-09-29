using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RacingGame
{
    public class Truck : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private Texture2D carTexture;
        private Vector2 position;
        private float speed = 3f;


        public Vector2 Position { get => position; }
        public bool IsOffScreen { get; private set; }

        public float Speed { get => speed; set => speed = value; }


        Vector2 scale = new Vector2(0.8f, 0.8f);

        public Rectangle BoundingBox
        {
            get
            {
                var centerX = position.X + carTexture.Width * scale.X /6;
                return new Rectangle((int)centerX, (int)position.Y, (int)(carTexture.Width * scale.X * 0.75), (int)(carTexture.Height * scale.Y));
            }
        }


        public Truck(Game game, SpriteBatch spriteBatch, Vector2 position) : base(game)
        {
            this.spriteBatch = spriteBatch;

            this.position = position;
            carTexture = game.Content.Load<Texture2D>("truck");

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            position.Y += speed;

            if (position.Y > Game.Window.ClientBounds.Height)
            {
                IsOffScreen = true;
            }
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.Begin();
            spriteBatch.Draw(carTexture, position, null, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

            spriteBatch.End();
        }
    }

}
