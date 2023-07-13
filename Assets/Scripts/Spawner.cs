using UnityEngine;
using System;

public class Spawner : MonoBehaviour {
	public float interval;
	private float currentTime;

	public GameObject pipes;

	public float pipeInterval;

	private int pipe = 1;

	private int day = (int)Math.Floor(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds / (1000 * 60 * 60 * 24));

	private float PipePosition(int pipeNumber)
    {
		return pipeInterval * (float)Math.Sin(Math.Pow(pipe - day, 2));
    }

	// Update is called once per frame
	void Update() {
		if (currentTime > interval)
		{
			GameObject newPipe = Instantiate(pipes);

			newPipe.transform.position = transform.position + new Vector3(0, PipePosition(pipe));

			pipe++;

			Destroy(newPipe, 10);

			currentTime = 0;
		}

		currentTime += Time.deltaTime;
	}
}
