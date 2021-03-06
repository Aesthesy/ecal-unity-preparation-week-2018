﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BouffeGenerator : MonoBehaviour {

    public GameObject bouffe;
    public Text scoreText;
    int score = 0;

    public void Generate(){
        GameObject newBouffe = Instantiate(bouffe);
        newBouffe.transform.position = new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10));
        score++;
        scoreText.text = score.ToString();
    }
}
