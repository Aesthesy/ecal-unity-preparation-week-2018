using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_eat : MonoBehaviour {
    public GameObject snakebody;
    public BouffeGenerator bouffegenerator;
    public List<GameObject> queue;

    private void Start()
    {
       queue = new List<GameObject>();
    }
    //Add IsTrigger on collider and RigidBody on player.
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bouffe"){
            Debug.Log("miam");
            Destroy(other.gameObject);
            bouffegenerator.Generate();
            GameObject sb = Instantiate(snakebody);
            sb.transform.position = gameObject.transform.position;
            queue.Add(sb);
        }    
    }

}
