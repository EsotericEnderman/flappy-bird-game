using UnityEngine;

public class MovePipes : MonoBehaviour {
	public float pipeSpeed;

	private void Update() {
		transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
	}
}
