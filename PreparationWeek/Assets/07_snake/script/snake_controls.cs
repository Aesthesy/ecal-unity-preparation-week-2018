using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_controls : MonoBehaviour {
    public float stepSpeed = 1f;
    Vector3 direction = Vector3.forward;

	// Use this for initialization
	void Start () {
        StartCoroutine(StepCoroutine());
	}

    IEnumerator StepCoroutine(){
        while (true)
        {
            yield return new WaitForSeconds(stepSpeed);
            Debug.Log("second");
            gameObject.transform.position += direction;
        }
    }

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            direction = Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector3.back;
        }
    }
}
