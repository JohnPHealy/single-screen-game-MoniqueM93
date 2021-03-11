using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score;  //static can be access from any files.
    public static GameObject[] pickupsInScene;
    public static int currentPickupCount;
    public TMP_Text scoreText;
    public TMP_Text pickupText;

    public static int pickupValue = 100;

    // Start is called before the first frame update
    void Start()
    {
        pickupsInScene = GameObject.FindGameObjectsWithTag("pickup"); //populating array with all objects are pickups
        currentPickupCount = pickupsInScene.Length;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        pickupText.text = "Pickups Left: " + currentPickupCount;
    }
}