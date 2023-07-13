using UnityEngine;

public class Quit : MonoBehaviour {
    public KeyCode exitGameKey;

    // Update is called once per frame.
    void Update() {
        if (Input.GetKeyDown(exitGameKey))
        {
            Application.Quit();
        }
    }
}
