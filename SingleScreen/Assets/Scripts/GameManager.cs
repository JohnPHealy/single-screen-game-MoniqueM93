using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score;  //static can be access from any files.
    public static GameObject[] pickupsInScene;
    public static int currentPickupCount;
    public TMP_Text scoreText;
    public TMP_Text pickupText;

    public static int pickupValue = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        currentPickupCount = pickupsInScene.Length;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        if (score == 12)
        {
            SceneManager.LoadScene(2);
            score = 0;
        }
    }
}