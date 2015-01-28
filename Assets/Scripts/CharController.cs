using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    public float rightBoundry;
    public float leftBoundry;
    public float topBoundry;
    public float bottomBoundry;
    float speed = 8.0f;

    private GameObject bullet;
    public GameObject paper;
    private GameObject movingPaper;
    private GameObject oldPaper;
    
    // Use this for initialization
	void Start () 
    {
        if (Application.loadedLevel == 2)
        {
            movingPaper = Instantiate(paper, new Vector2(7.715f, -1.83f), Quaternion.identity) as GameObject;
            movingPaper.rigidbody2D.velocity = new Vector2(-5, 0);
        }
	}

    void OnLevelWasLoaded()
    {
        if(Application.loadedLevel == 2)
            InvokeRepeating("PaperInvoker", 3.0f, 2.5f);
    }

    void PaperInvoker()
    {
        movingPaper = Instantiate(paper, new Vector2(transform.position.x - 0.5f, transform.position.y + 0.8f/*RandomPaperGenerator(-1.83f)*/), Quaternion.identity) as GameObject;
        movingPaper.rigidbody2D.velocity = new Vector2(-5, 0);
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

       /*if (movingPaper && movingPaper.transform.position.x < -12.0f)
       {
           oldPaper = movingPaper;
           Destroy(oldPaper);
           movingPaper = Instantiate(bullet, new Vector2(7.715f, RandomPaperGenerator(-1.83f)), Quaternion.identity) as GameObject;
           movingPaper.rigidbody2D.velocity = new Vector2(10, 0);
       }*/
        
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

        if(Application.loadedLevel == 0)
            Application.LoadLevel(1);
    }

    float RandomPaperGenerator(float number)
    {
        float newNumber = Random.Range(-4.85f, 0.9f);
        //Debug.Log("New number is: " + newNumber);

        if (newNumber != number)
            return newNumber;
        else
            return RandomPaperGenerator(newNumber);
    }

}
