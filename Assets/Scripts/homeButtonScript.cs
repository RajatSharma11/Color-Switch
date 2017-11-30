using UnityEngine;
using UnityEngine.SceneManagement;

public class homeButtonScript : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("homeScene");
    }
}
