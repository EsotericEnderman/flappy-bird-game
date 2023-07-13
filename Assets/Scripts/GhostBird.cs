using System.Collections.Generic;
using UnityEngine;

public class GhostBird : MonoBehaviour
{
    public List<FramePositionPair> inputTimes;
    public static GhostBird instance;

    public SpriteRenderer spriteRenderer;

    public new Rigidbody2D rigidbody;

    public int bounceMultiplier;

    private float currentTime;
    private int index;

    private bool isDead;

    // Start is called before the first frame update.
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        inputTimes = GhostBirdStaticClass.InputTimes;
        bounceMultiplier = GhostBirdStaticClass.BounceMultiplier;

        instance = this;
    }

    // Update is called once per frame.
    void Update()
    {
        if (currentTime == 0 && inputTimes.Count == 0)
        {
            spriteRenderer.enabled = false;
        }

        if (!isDead) rigidbody.velocity = Vector2.zero;

        // Check if the index exists in the list.
        if ((inputTimes.Count > index) && (currentTime >= inputTimes[index].time) && (rigidbody.velocity.y < 4))
        {
            rigidbody.position = inputTimes[index].position;

            index++;
        }

        currentTime += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
    }
}