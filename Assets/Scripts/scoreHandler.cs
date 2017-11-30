using UnityEngine;

public class scoreHandler : MonoBehaviour {

    public GameObject currentScore;
    public GameObject highScore;
    private TextMesh currentScoreText;
    private TextMesh highScoreText;

    private int current;
    private int high;

	// Use this for initialization
	void Start () {
        // targeting the textmesh component
        currentScoreText = currentScore.GetComponent<TextMesh>();
        highScoreText = highScore.GetComponent<TextMesh>();

        // changing the current score
        currentScoreText.text = PlayerPrefs.GetString("CurrentScore");

        // check if current score is higher than high score or not
        current = System.Convert.ToInt32(PlayerPrefs.GetString("CurrentScore"));
        if(!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetString("HighScore", "0");
        }
        high = System.Convert.ToInt32(PlayerPrefs.GetString("HighScore"));
        if(current > high)
        {
            PlayerPrefs.SetString("HighScore", System.Convert.ToString(current));
        }
        highScoreText.text = PlayerPrefs.GetString("HighScore");

    }
}
