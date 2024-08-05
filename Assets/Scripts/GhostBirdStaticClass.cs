using System.Collections.Generic;

public static class GhostBirdStaticClass
{

    private static List<FramePositionPair> inputTimes = new();

    public static List<FramePositionPair> InputTimes
    {
        get { return inputTimes; }
        set { inputTimes = value; }
    }
}
