using UnityEngine;

public class Quit : MonoBehaviour {
    public KeyCode exitGameKey;

    void Update() {
        if (Input.GetKeyDown(exitGameKey))
        {
            Application.Quit();
        }
    }
}
