using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static int score;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();

        score = 0;
    }

    void Update()
    {
        if (score == 15)
        {
            SceneManager.LoadScene/*("Win");*/(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            text.text = "Score: " + score;
        }
    }
    
}
