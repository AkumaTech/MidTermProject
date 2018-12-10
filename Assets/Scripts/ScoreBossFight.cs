using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreBossFight : MonoBehaviour {

    public static int score;

    Text text1;
    
    void Awake()
    {
        text1 = GetComponent<Text>();

        score = 0;
    }

    void Update()
    {
        if (score == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else
        {
            text1.text = "Score: " + score;
        }
    }
    
}
