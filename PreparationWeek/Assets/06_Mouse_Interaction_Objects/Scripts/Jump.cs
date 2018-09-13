using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float intensity = 10f;

    Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    public void JumpNow() {
        rb.AddForce(Vector3.up * intensity, ForceMode.Impulse);
    }
}
