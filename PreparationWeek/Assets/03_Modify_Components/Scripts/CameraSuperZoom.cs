using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSuperZoom : MonoBehaviour {

    Camera myCamera;

	void Start () {
        // 160 -> 20
        // Get object
        myCamera = gameObject.GetComponent<Camera>();
	}
	
	void Update () {
        // Change zoom
        //myCamera.fieldOfView = 20f;

        // Animate zoom
        /*
        if (myCamera.fieldOfView > 20f) { // Animate only if larger than 20f
            myCamera.fieldOfView -= 30f * Time.deltaTime;
        }*/

        // Animate zoom and stop with max function
        float newFieldOfView = myCamera.fieldOfView - 30f * Time.deltaTime;
        float contrainedFieldOfView = Mathf.Max(newFieldOfView, 20f);
        myCamera.fieldOfView = contrainedFieldOfView;

    }
}
