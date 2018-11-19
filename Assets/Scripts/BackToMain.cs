using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackToMain : MonoBehaviour {

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
