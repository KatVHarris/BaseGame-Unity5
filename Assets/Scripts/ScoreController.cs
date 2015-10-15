using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

    public static int score;        // The player's score.

    public GameObject textObject;                      // Reference to the Text component.
    Text text; 

    void Awake()
    {
        // Set up the reference.
        text = textObject.GetComponent<Text>();
        // Reset the score.

        score = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Bubbles: " + score;
    }
}
