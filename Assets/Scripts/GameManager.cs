using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public int score;
	public TMP_Text scoreText;
	public TMP_Text highScoreText;

	public static GameManager instance;

	public GameObject gameOverScreen;

	public float initialTimeScale;

	public int highScore;

	void Start() {
		instance = this;
		instance.highScore = HighScoreStaticClass.HighScore;

		Time.timeScale = initialTimeScale;
	}

	void Update() {
		if (scoreText != null)
		{ 
			scoreText.text = score.ToString();
		}

		highScoreText.text = HighScoreStaticClass.HighScore.ToString();
	}

	public void GameOver() {
		gameOverScreen.SetActive(true);

		Time.timeScale = 0.35f;
	}

	public void StartGame() {
		SceneManager.LoadScene("Flappy Bird");

		Time.timeScale = 1;
	}
}
