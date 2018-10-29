using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ending : MonoBehaviour {

	public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Finished()
    {
        Application.Quit();
    }
}
