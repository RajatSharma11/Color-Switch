using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour {

    // Change Scene when button is pressed
    private void OnMouseDown()
    {
        SceneManager.LoadScene("playScene");
    }
}
