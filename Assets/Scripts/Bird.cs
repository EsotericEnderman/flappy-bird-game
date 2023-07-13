using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	public KeyCode bounce;
	public int bounceMultiplier;

	private new Rigidbody2D rigidbody;

	public SpriteRenderer spriteRenderer;
	private float hue;
	public float colourChangeFactor;

	public static Bird instance;

	private float currentTime;
	public List<FramePositionPair> inputRecord = new List<FramePositionPair>();

	public bool isComputer;
	public KeyCode enableComputer;

	// Start is called before the first frame update.
	private void Start() {
		instance = this;
		rigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame.
	private void Update() {
		if (Input.GetKeyDown(enableComputer))
		{
			isComputer = true;
		}

		if ((Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetKeyDown(bounce)) && (rigidbody.velocity.y < 4) && (Time.timeScale != 0.35f)) {
			spriteRenderer.color = Color.HSVToRGB(hue, 1, 1);

			hue += colourChangeFactor;
			hue %= 1;

			rigidbody.AddForce(Vector2.up * bounceMultiplier);
		}

		inputRecord.Add(new FramePositionPair(currentTime, rigidbody.position, rigidbody.velocity));

		currentTime+=Time.deltaTime;
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		if (GameManager.instance.score >= HighScoreStaticClass.HighScore)
		{
			HighScoreStaticClass.HighScore = GameManager.instance.score;

			GhostBirdStaticClass.InputTimes = inputRecord;
			GhostBirdStaticClass.BounceMultiplier = bounceMultiplier;
		}

		GameManager.instance.GameOver();
	}
}
