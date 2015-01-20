using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    public float rightBoundry;
    public float leftBoundry;
    public float topBoundry;
    public float bottomBoundry;
    float speed = 8.0f;

    private GameObject bullet;
    
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetAxis("Horizontal") != 0)
            transform.position = new Vector3((transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime), transform.position.y, transform.position.z);

        if (Input.GetAxis("Vertical") != 0)
            transform.position = new Vector3(transform.position.x, (transform.position.y + Input.GetAxis("Vertical") * speed * Time.deltaTime), transform.position.z);

       if (transform.position.x > rightBoundry)
            transform.position = new Vector3(rightBoundry, transform.position.y, transform.position.z);

       if (transform.position.x < leftBoundry)
            transform.position = new Vector3(leftBoundry, transform.position.y, transform.position.z);

       if (transform.position.y > topBoundry)
           transform.position = new Vector3(transform.position.x, topBoundry, transform.position.z);

       if (transform.position.y < bottomBoundry)
           transform.position = new Vector3(transform.position.x, bottomBoundry, transform.position.z);
        
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }

    void OnDestroy()
    {
        bullet = GameObject.FindWithTag("Bullet");
        Destroy(bullet);
    }
}
