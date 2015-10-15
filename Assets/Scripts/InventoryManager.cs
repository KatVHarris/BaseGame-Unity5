using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour {

    public int bubbleCount = 0;
    public GameObject scoreManager;
    ScoreController sc; 
    // Use this for initialization
    void Start()
    {
        sc = scoreManager.GetComponent<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddBubble()
    {
        bubbleCount = bubbleCount + 1; // bubbleCount++; 
        ScoreController.score++;
    }
}
