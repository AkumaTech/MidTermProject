using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Winner : MonoBehaviour {

	public void Win()
    {
        SceneManager.LoadScene(0);//(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
