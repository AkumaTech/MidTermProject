using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int health;
    private int currentHealth;
    public int scoreValue = 1;



    // Use this for initialization
    void Start()
    {
        currentHealth = health;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            ScoreManager.score += scoreValue;
            Destroy(gameObject);

        }
    }
    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;

    }

}   
