using UnityEngine;

public class ScoringZone : MonoBehaviour
{
	private void OnTriggerEnter2D()
	{
		GameManager gameManager = GameManager.instance;

		// If the player hasn't died.
		if (!gameManager.isGameOver)
		{
			gameManager.score++;
		}
	}
}
