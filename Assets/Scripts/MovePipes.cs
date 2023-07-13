using UnityEngine;

public class MovePipes : MonoBehaviour {
	public float pipeSpeed;

	// Update is called once per frame.
	private void Update() {
		transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
	}
}
