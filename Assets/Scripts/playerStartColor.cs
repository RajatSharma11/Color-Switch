using UnityEngine;

public class playerStartColor : MonoBehaviour {

    private SpriteRenderer playerSprite;

    public void startColorChanger()
    {
        int ran = Random.Range(0, 4);
        playerSprite = GetComponent<SpriteRenderer>();

        switch(ran)
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
            case 3:
                // Change color to cyan
                playerSprite.color = new Color(0f, 1f, 1f);
                name = "Cyan";
                break;
        }
    }

	// Use this for initialization
	void Start () {
        startColorChanger();
	}
	
}
