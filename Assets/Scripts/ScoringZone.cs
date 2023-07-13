using UnityEngine;

public class ScoringZone : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D collision) {
		// If the player hasn't died.
		if (Time.timeScale != 0.35f) {
			GameManager.instance.score++;
		}
	}
}
