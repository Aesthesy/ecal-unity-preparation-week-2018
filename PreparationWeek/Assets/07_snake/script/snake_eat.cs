﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_eat : MonoBehaviour {
    public BouffeGenerator bouffegenerator;
    //Add IsTrigger on collider and RigidBody on player.
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bouffe"){
            Debug.Log("miam");
            Destroy(other.gameObject);
            bouffegenerator.Generate();
        }    
    }

}
