using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    //public int enemiesSpawned = 0;
    //public int maxEnemies = 5;
    public bool stop;

    //int randEnemy;

	// Use this for initialization
	void Start () {

        StartCoroutine(Spawn());
		
	}
	
	// Update is called once per frame
	void Update () {

        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

        
		
	}

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startWait);

        while(!stop)
        {
            //randEnemy = Random.Range(0, 2);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(enemies[0], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
