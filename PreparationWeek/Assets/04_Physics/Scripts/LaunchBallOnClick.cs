using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBallOnClick : MonoBehaviour {

    Rigidbody rb;
    public float intensity = 1f;

    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		
        // When click
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Mouse clicked");
            rb.AddForce(Vector3.forward * intensity, ForceMode.Acceleration);
        }

	}
}
