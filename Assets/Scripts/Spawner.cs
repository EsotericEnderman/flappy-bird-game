using UnityEngine;
using System;

using Random = System.Random;

public class Spawner : MonoBehaviour
{

	public GameObject pipePrefab;

	private readonly Random randomNumberGenerator = new((int)Math.Floor(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds / (1000 * 60 * 60 * 24)));

	private readonly float pipeSpawnIntervalSeconds = 1F;
	private readonly float verticalPipeInterval = 2.2F;
	private readonly float pipeDestroyDelaySeconds = 10F;

	private float timeSinceLastPipeSpawn = 0F;

	private double GetPipePosition()
	{
		return verticalPipeInterval * randomNumberGenerator.NextDouble();
	}

	void Update()
	{
		if (timeSinceLastPipeSpawn > pipeSpawnIntervalSeconds)
		{
			GameObject newPipe = Instantiate(pipePrefab);
			newPipe.transform.position = transform.position + new Vector3(0F, (float)GetPipePosition());
			Destroy(newPipe, pipeDestroyDelaySeconds);

			timeSinceLastPipeSpawn = 0F;
		}

		timeSinceLastPipeSpawn += Time.deltaTime;
	}
}
