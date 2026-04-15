using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Intro_to_monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture;
        Texture2D cityTexture;
        Texture2D godsTexture;
        Texture2D fireTexture;
        Texture2D girlsadTexture;
        Texture2D purpTexture;
        Texture2D woopTexture;
        int randNum;
        





        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            




            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            ;

            _graphics.PreferredBackBufferWidth = 800; 
            _graphics.PreferredBackBufferHeight = 500; 
            _graphics.ApplyChanges();
           
           


            this.Window.Title = "My First Monogame Project";

            Random generator = new Random();
            
            randNum = generator.Next(1, 4);
            
            




                base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            if (randNum == 1)
            {
                cityTexture = Content.Load<Texture2D>("purp");
            }
            else if (randNum == 2)
            {
                cityTexture = Content.Load<Texture2D>("woop");
            }
            else if (randNum == 3)
            {
                cityTexture = Content.Load<Texture2D>("city");
            }
            
            dinoTexture = Content.Load<Texture2D>("dino");
            godsTexture = Content.Load<Texture2D>("gods");
            fireTexture = Content.Load<Texture2D>("fire");
            girlsadTexture = Content.Load<Texture2D>("girlsad");
            

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Red);

            _spriteBatch.Begin();
           
           
            
            _spriteBatch.Draw(cityTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(10, 10), Color.White);

            if (randNum == 1)
            {
                _spriteBatch.Draw(godsTexture, new Vector2(5, 200), Color.White);
            }
            else if (randNum ==2)
            {
                _spriteBatch.Draw(godsTexture, new Vector2(100, 200), Color.White);
            }
            else if (randNum == 3)
            {
                _spriteBatch.Draw(godsTexture, new Vector2(200, 200), Color.White);
            }

            
            
            _spriteBatch.Draw(fireTexture, new Vector2(600, 0), Color.White);
            _spriteBatch.Draw(girlsadTexture, new Vector2(600, 250), Color.White);

            


            _spriteBatch.End();


            // TODO: Add your drawing code here


            

            base.Draw(gameTime);
        }
    }
}
