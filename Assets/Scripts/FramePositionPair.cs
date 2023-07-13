using UnityEngine;

public class FramePositionPair
{
    public float time;
    public Vector2 position;
    public Vector2 velocity;

    public FramePositionPair(float time, Vector2 position, Vector2 velocity)
    {
        this.time = time;
        this.position = position;
        this.velocity = velocity;
    }
}
