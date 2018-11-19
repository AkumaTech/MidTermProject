using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ending : MonoBehaviour {

	public void gameOver()
    {
        SceneManager.LoadScene("Menu");//(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Finished()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
