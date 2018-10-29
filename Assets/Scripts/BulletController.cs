using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;

    public float lifeTime;

    public int damageToGive;

    //private int Counter;

    //public Text countText;

	// Use this for initialization
	void Start () {
        //Counter = 0;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealth>().HurtEnemy(damageToGive);
            Destroy(gameObject);
            //Counter = Counter + 1;
            //RecordCount();
        }
    }

    /*void RecordCount()
    {
        countText.text = "Count: " + Counter.ToString();
    }*/

}
