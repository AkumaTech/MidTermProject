using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public float multiplier = 1f;
    public int lives = 1;

    //public GameObject pickupEffect;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
            ScorePlayerHealth.health += lives;
        }
    }

    void Pickup(Collider player)
    {
        //Pick up effect               
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        //makes player bigger
        //player.transform.localScale *= multiplier; 

        //Increases player health
        PlayerHealth stats = player.GetComponent<PlayerHealth>();
        stats.currentHealth += multiplier;

        Destroy(gameObject);
    }
}
