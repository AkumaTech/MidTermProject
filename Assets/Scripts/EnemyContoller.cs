using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyContoller : MonoBehaviour {

    private Rigidbody enemyRB;
    public float moveSpeed;

    public PlayerController thePlayer;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
    }

    void FixedUpdate()
    {
        enemyRB.velocity = (transform.forward * moveSpeed);
    }

    void Update()
    {
        transform.LookAt(thePlayer.transform.position);
        
    }

}
