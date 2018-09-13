using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBallTrajectory : MonoBehaviour {

    Rigidbody rb;
    public float intensity = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(gameObject.transform.position,
                        gameObject.transform.position + gameObject.transform.forward * 3f);
        //Gizmos.DrawSphere(transform.position, 1);
    }

    void Update()
    {
        // Update dir
        //Debug.Log(Input.mousePosition);

        float heightPct = Input.mousePosition.y / Screen.height;
        heightPct = Mathf.Clamp01(heightPct);
        // 0 -> 1
        // 0 -> -90
        var lr = gameObject.transform.localRotation.eulerAngles;
        lr.x = heightPct * -90f;

        gameObject.transform.eulerAngles = lr;

        // When click
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse clicked");
            rb.AddForce(gameObject.transform.forward * intensity, ForceMode.Acceleration);
        }

    }
}
