using UnityEngine;
using System.Collections;

public class GameManagerController : MonoBehaviour {

	public Transform terorist1;
    public Transform terorist2;
    public Transform charb;
    public Transform bullet;

    private float timer = 0f;
    private bool isItTime = false;
    
    // Use this for initialization
	void Start () 
    {
        //timer = Time.deltaTime;
        Instantiate(terorist1, new Vector2(-8.57f, -2.42f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (isItTime == false)
        {
            if (timer < 10.0f)
            {
                timer += Time.deltaTime;
            }

            Debug.Log("timer: " + timer);

            if (timer > 10.0f)
            {
                Instantiate(terorist2, new Vector2(-8.36f, -0.92f), Quaternion.identity);
                isItTime = true;
            }
        }
            
         
          //if (bullet.transform.position.x > 12.0f)
        //    Destroy(bullet);
	}
}
