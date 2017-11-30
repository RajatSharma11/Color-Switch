using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

    private SpriteRenderer playerSprite;
    public GameObject score;
    private TextMesh scoreText;
    public ParticleSystem starParticle;
    public ParticleSystem plusOne;
    public ParticleSystem gameOverRed;
    public ParticleSystem gameOverCyan;
    public ParticleSystem gameOverMagenta;
    public ParticleSystem gameOverYellow;

    private SpriteRenderer playerSpriteRender;
    private Rigidbody2D playerBody;


    private void Start()
    {
        scoreText = score.GetComponent<TextMesh>();
        PlayerPrefs.SetString("CurrentScore", "0");
        playerSpriteRender = GetComponent<SpriteRenderer>();
        playerBody = GetComponent<Rigidbody2D>();
    }

    public void killPlayer()
    {
        SceneManager.LoadScene("gameoverScene");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // check whether player is collided with obstacle or not
        if(collision.tag == "Obstacle")
        {
            if(collision.name != name)
            {
                if(name == "Red")
                {
                    gameOverRed.Play();
                }
                else if (name == "Cyan")
                {
                    gameOverCyan.Play();
                }
                else if (name == "Magenta")
                {
                    gameOverMagenta.Play();
                }
                else if (name == "Yellow")
                {
                    gameOverYellow.Play();
                }

                PlayerPrefs.SetString("CurrentScore",scoreText.text);   // PlayerPrefs is used to store value permanently, until we remove it; it is used here to store current game score
                playerSpriteRender.enabled = false;                     // making the player disappear on touching Obstacle
                playerBody.constraints = RigidbodyConstraints2D.FreezePositionY;        // Freeze y movement so that player doesnot move after hitting the Obstacle
                Invoke("killPlayer", 1);
            }
        }

        // check whether player is collided with the Color changer
        else if(collision.tag == "ColorChanger")
        {
            Destroy(collision.gameObject);      // destroying the color changer

            playerSprite = GetComponent<SpriteRenderer>();
            // if player is yellow
            if(name == "Yellow")
            {
                int ran = Random.Range(0, 3);

                switch (ran)
                {
                    case 0:
                        // Change color to red
                        playerSprite.color = new Color(1f, 0f, 0f);
                        name = "Red";
                        break;
                    case 1:
                        // Change color to magenta
                        playerSprite.color = new Color(1f, 0f, 1f);
                        name = "Magenta";
                        break;
                    case 2:
                        // Change color to cyan
                        playerSprite.color = new Color(0f, 1f, 1f);
                        name = "Cyan";
                        break;
                }
            }
            // if player is red
            else if (name == "Red")
            {
                int ran = Random.Range(0, 3);

                switch (ran)
                {
                    case 0:
                        // Change color to yellow
                        playerSprite.color = new Color(1f, 1f, 0f);
                        name = "Yellow";
                        break;
                    case 1:
                        // Change color to magenta
                        playerSprite.color = new Color(1f, 0f, 1f);
                        name = "Magenta";
                        break;
                    case 2:
                        // Change color to cyan
                        playerSprite.color = new Color(0f, 1f, 1f);
                        name = "Cyan";
                        break;
                }
            }
            // if player is cyan
            else if (name == "Cyan")
            {
                int ran = Random.Range(0, 3);

                switch (ran)
                {
                    case 0:
                        // Change color to red
                        playerSprite.color = new Color(1f, 0f, 0f);
                        name = "Red";
                        break;
                    case 1:
                        // Change color to yellow
                        playerSprite.color = new Color(1f, 1f, 0f);
                        name = "Yellow";
                        break;
                    case 2:
                        // Change color to magenta
                        playerSprite.color = new Color(1f, 0f, 1f);
                        name = "Magenta";
                        break;
                }
            }
            // if player is magenta
            else if (name == "Magenta")
            {
                int ran = Random.Range(0, 3);
                switch (ran)
                {
                    case 0:
                        // Change color to red
                        playerSprite.color = new Color(1f, 0f, 0f);
                        name = "Red";
                        break;
                    case 1:
                        // Change color to yellow
                        playerSprite.color = new Color(1f, 1f, 0f);
                        name = "Yellow";
                        break;
                    case 2:
                        // Change color to cyan
                        playerSprite.color = new Color(0f, 1f, 1f);
                        name = "Cyan";
                        break;
                }
            }
            
        }

        // check whether player is collided with the point

        else if(collision.tag == "Point")
        {
            // +1 to Score
            scoreText.text = System.Convert.ToString(System.Convert.ToInt32(scoreText.text) + 1);
            Destroy(collision.gameObject);
            starParticle.Play();
            plusOne.Play();
        }
    }
}
