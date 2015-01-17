using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    float speed = 8.0f;
    
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

       /* if (transform.position.x > xBoundry)
            transform.position = new Vector3(xBoundry, transform.position.y, transform.position.z);

        if (transform.position.x < -xBoundry)
            transform.position = new Vector3(-xBoundry, transform.position.y, transform.position.z);
        * */
	}
}
