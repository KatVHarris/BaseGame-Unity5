using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    float restartTimer;                     // Timer to count up to restarting the level
    public float restartDelay = 35f;         // Time to wait before restarting the level

    InventoryManager inventory;
    public GameObject player;
    public int maxBubble = 3;
    public Animator anim;

    // Use this for initialization
    void Awake()
    {
        //playerobject = GameObject.Find ("Player");
        inventory = player.GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check to see if Inventory has max bubbles
        if (inventory.bubbleCount == maxBubble)
        {

            // .. then reload the currently loaded level.
            Application.LoadLevel(Application.loadedLevel);

        }

    }
}
