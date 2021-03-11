using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reward : MonoBehaviour
{
    public bool pickedUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && pickedUp == false)
        {
            pickedUp = true;
            GameManager.currentPickupCount = GameManager.currentPickupCount - 1;
            GameManager.score = GameManager.score + GameManager.pickupValue;
            Destroy(gameObject);
        }
    }
}
