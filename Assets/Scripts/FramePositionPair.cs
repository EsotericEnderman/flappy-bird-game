using UnityEngine;

public class FramePositionPair
{

    private readonly float time;
    private readonly Vector2 position;

    public float Time {
        get => time;
    }

    public Vector2 Position {
        get => position;
    }

    public FramePositionPair(float time, Vector2 position)
    {
        this.time = time;
        this.position = position;
    }
}
