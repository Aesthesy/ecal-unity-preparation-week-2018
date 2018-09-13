using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {

    public float speed = 2f;

	void Update () {
        // Get keyboard inputs
        // Move according to keyboard inputs

        //Debug.Log(Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up key pressed");
            // Increment Z axis
            // Time.deltaTime - special Unity variable
            gameObject.transform.position = 
                gameObject.transform.position + 
                new Vector3(0f, 0f, 1f) * Time.deltaTime * speed; 
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Down key pressed");
            // Modify z position

            // This will not work
            // Immutable objects
            // gameObject.transform.position.z -= 1f;

            // Make a copy
            // Modify the copy
            // Replace the original with the copy
            Vector3 positionCopy = gameObject.transform.position;
            positionCopy.z = positionCopy.z - 1f * Time.deltaTime * speed;
            gameObject.transform.position = positionCopy;
        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left key pressed");
            // Decrement X
            gameObject.transform.position =
                gameObject.transform.position +
                         Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right key pressed");
            gameObject.transform.position =
                gameObject.transform.position +
                          Vector3.right * Time.deltaTime * speed;
        }
    }
}
