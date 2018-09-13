using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideLineRenderer : MonoBehaviour {

    LineRenderer lr;

    float lastTimeCollided = 0f;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "ground" && lastTimeCollided > 3f)
        {
            lr.enabled = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ground") {
            // Show line renderer
            lastTimeCollided = Time.time;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "ground")
        {
            // Hide line renderer
            lr.enabled = false;
        }
    }

    void Start () {
        lr = GetComponentInChildren<LineRenderer>();
        lastTimeCollided = Time.time;

    }

}
