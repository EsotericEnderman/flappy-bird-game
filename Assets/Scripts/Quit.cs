using UnityEngine;

public class Quit : MonoBehaviour
{

    private readonly KeyCode exitGameKey = KeyCode.Escape;

    void Update()
    {
        if (Input.GetKeyDown(exitGameKey))
        {
            Application.Quit();
        }
    }
}
