using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float startingHealth;
    public float currentHealth;
    

	// Use this for initialization
	void Start ()
    {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("Died");

        }

	}

   
    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
    }
}
