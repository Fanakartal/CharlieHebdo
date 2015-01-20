using UnityEngine;
using System.Collections;

public class GameManagerController : MonoBehaviour {

	public Transform terorist1;
    public Transform terorist2;
    public Transform charb;
    public Transform bullet;
    
    // Use this for initialization
	void Start () 
    {
        Instantiate(terorist1, new Vector2(-8.57f, -2.42f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        /** if(Time.deltaTime > 10.0f && Time.deltaTime < 12.0f)
            Instantiate(terorist2, new Vector2(-8.36f, -0.92f), Quaternion.identity); */
            
         
          //if (bullet.transform.position.x > 12.0f)
        //    Destroy(bullet);
	}
}
