using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackToMain : MonoBehaviour {

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
