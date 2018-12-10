using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlayerHealth : MonoBehaviour {

    public static float health;

    Text text1;

    void Awake()
    {
        text1 = GetComponent<Text>();

        health = 1;
    }

    void Update()
    {

        text1.text = "Lives: " + health;
        
    }

}
