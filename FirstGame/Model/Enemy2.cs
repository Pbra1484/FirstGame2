﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FirstGame.View;

namespace FirstGame
{
	public class Enemy2
	{

		// Animation representing the enemy
		public Texture2D EnemyTexture;

		// The position of the enemy ship relative to the top left corner of thescreen
		public Vector2 Position;

		// The state of the Enemy Ship
		public bool Active;

		// The hit points of the enemy, if this goes to zero the enemy dies
		public int Health;

		// The amount of damage the enemy inflicts on the player ship
		public int Damage;

		// The amount of score the enemy will give to the player
		public int Value;

		// Get the width of the enemy ship
		public int Width
		{
			get { return EnemyTexture.Width; }
		}

		// Get the height of the enemy ship
		public int Height
		{
			get { return EnemyTexture.Height; }
		}

		// The speed at which the enemy moves
		float enemyMoveSpeed;

		public void Initialize(Texture2D texture, Vector2 position)
		{
			// Load the enemy ship texture
			EnemyTexture = texture;

			// Set the position of the enemy
			Position = position;

			// We initialize the enemy to be active so it will be update in the game
			Active = true;


			// Set the health of the enemy
			Health = 50;

			// Set the amount of damage the enemy can do
			Damage = 40;

			// Set how fast the enemy moves
			enemyMoveSpeed = 1f;


			// Set the score value of the enemy
			Value = 301;

		}

		public void Update(GameTime gameTime)
		{
			// The enemy always moves to the left so decrement it's xposition
			Position.X -= enemyMoveSpeed;





			// If the enemy is past the screen or its health reaches 0 then deactivateit
			if (Position.X < -Width || Health <= 0)
			{
				// By setting the Active flag to false, the game will remove this objet fromthe
				// active game list
				Active = false;
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(EnemyTexture, Position, null, Color.White, 0f,
			new Vector2(Width / 2, Height / 2), 1f, SpriteEffects.None, 0f);
		}
		public Enemy2()
		{
		}
	}
}
