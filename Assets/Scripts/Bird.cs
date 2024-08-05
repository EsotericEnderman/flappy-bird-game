using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : MonoBehaviour
{

	public static Bird instance;

	public new Rigidbody2D rigidbody;
	public SpriteRenderer spriteRenderer;

	private readonly KeyCode bounce = KeyCode.Space;
	private readonly int bounceMultiplier = 200;
	private readonly float colourChangeFactor = 0.1F;

	private float currentTime = 0F;
	private readonly List<FramePositionPair> inputRecord = new();
	private float hue = 0F;

	private void Start()
	{
		instance = this;
	}

	private void Update()
	{
		if ((Input.GetMouseButtonDown((int)MouseButton.Left) || Input.GetMouseButtonDown((int)MouseButton.Right) || Input.GetKeyDown(bounce)) && !GameManager.instance.isGameOver)
		{
			spriteRenderer.color = Color.HSVToRGB(hue, 1, 1);

			hue += colourChangeFactor;
			hue %= 1;

			rigidbody.AddForce(Vector2.up * bounceMultiplier);
		}

		inputRecord.Add(new FramePositionPair(currentTime, rigidbody.position));

		currentTime += Time.deltaTime;
	}

	private void OnCollisionEnter2D()
	{
		if (GameManager.instance.score >= HighScoreStaticClass.HighScore)
		{
			HighScoreStaticClass.HighScore = GameManager.instance.score;

			GhostBirdStaticClass.InputTimes = inputRecord;
		}

		GameManager.instance.GameOver();
	}
}
