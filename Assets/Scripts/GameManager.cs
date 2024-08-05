using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public static GameManager instance;

	public GameObject gameOverScreen;

	public TMP_Text scoreText;
	public TMP_Text highScoreText;

	private readonly float initialTimeScale = 1F;
	private readonly float gameOverTimeScale = 0.35F;

	public int score = 0;
	public int highScore = 0;

	public bool isGameOver = false;

	void Start()
	{
		instance = this;
		instance.highScore = HighScoreStaticClass.HighScore;

		Time.timeScale = initialTimeScale;
	}

	void Update()
	{
		if (scoreText != null)
		{
			scoreText.text = score.ToString();
		}

		highScoreText.text = HighScoreStaticClass.HighScore.ToString();
	}

	public void GameOver()
	{
		gameOverScreen.SetActive(true);

		Time.timeScale = gameOverTimeScale;
	}

	public void StartGame()
	{
		SceneManager.LoadScene("Flappy Bird");

		Time.timeScale = initialTimeScale;
		isGameOver = true;
	}
}
