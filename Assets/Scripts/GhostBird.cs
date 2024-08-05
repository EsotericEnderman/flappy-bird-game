using System.Collections.Generic;
using UnityEngine;

public class GhostBird : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public new Rigidbody2D rigidbody;

    private List<FramePositionPair> inputTimes;

    private int currentIndex = 0;
    private float currentTime = 0F;

    private bool isDead = false;

    void Start()
    {
        inputTimes = GhostBirdStaticClass.InputTimes;
    }

    void Update()
    {
        if (currentTime == 0F && inputTimes.Count == 0)
        {
            spriteRenderer.enabled = false;
        }

        if (!isDead) rigidbody.velocity = Vector2.zero;

        // Check if the index exists in the list.
        if ((inputTimes.Count > currentIndex) && (currentTime >= inputTimes[currentIndex].Time))
        {
            rigidbody.position = inputTimes[currentIndex].Position;

            currentIndex++;
        }

        currentTime += Time.deltaTime;
    }

    private void OnCollisionEnter2D()
    {
        isDead = true;
    }
}