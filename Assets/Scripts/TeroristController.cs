using UnityEngine;
using System.Collections;

public class TeroristController : MonoBehaviour {

    public GameObject bullet;
    private GameObject movingBullet;
    private GameObject oldBullet;
    
    // Use this for initialization
	void Start () 
    {


        movingBullet = Instantiate(bullet, new Vector2(-7.13f, -1.54f), Quaternion.identity) as GameObject;
        movingBullet.rigidbody2D.velocity = new Vector2(5, 0);
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
            movingBullet.rigidbody2D.velocity = new Vector2(5, 0);
        }
        
        /*if (!movingBullet)
        {
            movingBullet = Instantiate(bullet, new Vector2(-7.13f, -1.54f), Quaternion.identity) as GameObject;
            movingBullet.rigidbody2D.velocity = new Vector2(5, 0);

            
        }*/
	}

    float RandomBulletGenerator(float number)
    {
        float newNumber = Random.Range(-4.85f, 0.9f);
        Debug.Log("New number is: " + newNumber);

        if (newNumber != number)
            return newNumber;
        else
            return RandomBulletGenerator(newNumber);
    }

    
}
