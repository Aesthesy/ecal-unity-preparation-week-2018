using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	void Start () {
        Debug.Log(gameObject.name);
	}
	
    // Like draw in Processing
    void Update () {
        transform.position = transform.position + Vector3.left * 0.1f * Time.deltaTime;
	}
}
