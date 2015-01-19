using UnityEngine;
using System.Collections;

public class GameManagerController : MonoBehaviour {

	public Transform terorist;
    
    // Use this for initialization
	void Start () 
    {
        Instantiate(terorist, new Vector2(-8.57f, -2.42f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
