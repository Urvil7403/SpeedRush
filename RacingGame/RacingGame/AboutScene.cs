using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RacingGame
{
    public class AboutScene : GameScene
    {
        private SpriteBatch spriteBatch;

        private Rectangle rectangle;
        private string aboutText = "Created by : \n\nMalav Brahmbhatt - 8833650 \nShrey Patel - 8865805 \nUrvil Shah - 8845239 \nSneh Patel - 886860";

        Vector2 textSize;
        Vector2 textPosition;

        private SpriteFont font, titleFont;

        public AboutScene(Game game) : base(game)
        {
            Game1 g = (Game1)game;
            this.spriteBatch = g._spriteBatch;

            font = g.Content.Load<SpriteFont>("RegularFont");
            titleFont = g.Content.Load<SpriteFont>("TitleFont");

            textSize = font.MeasureString(aboutText);

            rectangle = new Rectangle(0, 0, g.GraphicsDevice.Viewport.Width, g.GraphicsDevice.Viewport.Height);
        }


        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            textPosition = new Vector2(rectangle.Center.X - textSize.X / 2, rectangle.Center.Y - textSize.Y);

            spriteBatch.DrawString(titleFont, "About", new Vector2(rectangle.Center.X - titleFont.MeasureString("About").X / 2, rectangle.Center.Y - textSize.Y - 50), Color.White);

            spriteBatch.DrawString(font, aboutText, textPosition, Color.White);



            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
