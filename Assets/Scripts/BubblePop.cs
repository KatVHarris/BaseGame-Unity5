using UnityEngine;
using System.Collections;

public class BubblePop : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
        GameObject objectHit = collision.gameObject;

        if (objectHit.tag == "Player")
        {
            //Update Player Inventory with Bubble
            objectHit.GetComponent<InventoryManager>().AddBubble();
            Destroy(this.gameObject);
        }

    }
}
