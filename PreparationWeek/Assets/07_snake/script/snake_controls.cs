using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_controls : MonoBehaviour {
    public float stepSpeed = 1f;
    Vector3 direction = Vector3.forward;
    public List<Vector3> pPos;
    snake_eat se;

    // Use this for initialization
    void Start () {
        se = GetComponent<snake_eat>();
        StartCoroutine(StepCoroutine());
        pPos = new List<Vector3>();
    }

    IEnumerator StepCoroutine(){
        while (true)
        {
            yield return new WaitForSeconds(stepSpeed);
            Debug.Log("second");
            pPos.Add(gameObject.transform.position);
            gameObject.transform.position += direction;

            // remove extra positions
            while (pPos.Count > se.queue.Count) {
                pPos.RemoveAt(0);
            }

            // Mettre les cubes du queue à la bonne position
            //se.queue

            for (int i = 0; i < se.queue.Count; i++) {
                GameObject queueCube = se.queue[i];
                queueCube.transform.position = pPos[i];
            }
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
