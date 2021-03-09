using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firekill : MonoBehaviour
{

    Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindWithTag("spawnPoint").transform;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = spawnPoint.position;
        }
    }
}
