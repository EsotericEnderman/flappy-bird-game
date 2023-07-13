using System.Collections.Generic;

public static class GhostBirdStaticClass
{
    private static List<FramePositionPair> inputTimes = new List<FramePositionPair>();
    private static int bounceMultiplier = 200;

    public static List<FramePositionPair> InputTimes {
        get { return inputTimes; }
        set { inputTimes = value;  }
    }

    public static int BounceMultiplier
    {
        get { return bounceMultiplier; }
        set { bounceMultiplier = value;  }
    }
}
