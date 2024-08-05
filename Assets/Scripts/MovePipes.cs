using UnityEngine;

public class MovePipes : MonoBehaviour
{

	private readonly float pipeSpeedPerSecond = 4F;

	private void Update()
	{
		transform.position += Vector3.left * pipeSpeedPerSecond * Time.deltaTime;
	}
}
