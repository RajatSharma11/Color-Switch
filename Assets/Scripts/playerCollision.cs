using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // check whether player is collided with obstacle or not
        if(collision.tag == "Obstacle")
        {
            if(collision.name != name)
            {
                SceneManager.LoadScene("gameoverScene");
            }
        }
        // check whether player is collided with the point

        // check whether player is collided with the Color changer
    }
}
