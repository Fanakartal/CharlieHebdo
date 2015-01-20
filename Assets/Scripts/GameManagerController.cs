using UnityEngine;
using System.Collections;

public class GameManagerController : MonoBehaviour {

	public Transform terorist;
    public Transform charb;
    public Transform bullet;
    
    // Use this for initialization
	void Start () 
    {
        Instantiate(terorist, new Vector2(-8.57f, -2.42f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () 
    {
        //if (bullet.transform.position.x > 12.0f)
        //    Destroy(bullet);
	}
}
