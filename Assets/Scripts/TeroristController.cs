using UnityEngine;
using System.Collections;

public class TeroristController : MonoBehaviour {

    public GameObject bullet;
    private GameObject movingBullet;
    private GameObject oldBullet;
    private float bulletPoint;
    
    // Use this for initialization
	void Start () 
    {

        bulletPoint = -1.54f;

        movingBullet = Instantiate(bullet, new Vector2(-7.13f, bulletPoint), Quaternion.identity) as GameObject;
        movingBullet.rigidbody2D.velocity = new Vector2(6, 0);
        //movingBullet.AddForce(transform.forward * 10);
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (movingBullet && movingBullet.transform.position.x > 12.0f)
        {
            oldBullet = movingBullet;
            Destroy(oldBullet);
            movingBullet = Instantiate(bullet, new Vector2(-7.13f, RandomBulletGenerator(-1.54f)), Quaternion.identity) as GameObject;
            movingBullet.rigidbody2D.velocity = new Vector2(6, 0);
        }
        
        /*if (!movingBullet)
        {
            movingBullet = Instantiate(bullet, new Vector2(-7.13f, -1.54f), Quaternion.identity) as GameObject;
            movingBullet.rigidbody2D.velocity = new Vector2(5, 0);

            
        }*/
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Paper")
        {
            //Destroy(gameObject);
        }
    }

    float RandomBulletGenerator(float number)
    {
        float newNumber = Random.Range(-4.85f, 0.9f);
        //Debug.Log("New number is: " + newNumber);

        if (newNumber != number)
            return newNumber;
        else
            return RandomBulletGenerator(newNumber);
    }

    
}
