using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        // Check collision by name - not best way
        /* if (collision.collider.gameObject.name == "Cube") {
            Debug.Log("We hit the cube");
        }*/ 

        // Check collision by tag
        if (collision.collider.gameObject.tag == "target")
        {
            Debug.Log("We hit the cube");
        }
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
