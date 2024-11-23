using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace SongProblem
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;

		private Song mSong;
		private SoundEffect mSongAsSoundEffect;
		private SoundEffectInstance mSFXInstance;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			base.Initialize();
		}

		protected override void LoadContent()
		{
			mSong = Content.Load<Song>("Song");
			mSongAsSoundEffect = Content.Load<SoundEffect>("SongAsSFX");

			// Change me to see how MediaPlayer and SoundEffect differ.
			const bool playSongAsSFX = true;

			if(playSongAsSFX)
			{
				PlaySongAsSFX();
			}
			else
			{
				PlaySong();
			}
		}

		private void PlaySong()
		{
			MediaPlayer.Volume = 0.3f;
			MediaPlayer.IsRepeating = true;

			MediaPlayer.Play(mSong);
		}

		private void PlaySongAsSFX()
		{
			mSFXInstance = mSongAsSoundEffect.CreateInstance();
			mSFXInstance.IsLooped = true;
			mSFXInstance.Volume = 0.3f;

			mSFXInstance.Play();
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			base.Draw(gameTime);
		}
	}
}
