﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymake : MonoBehaviour {

    public GameObject Enemy;
    void SpawnEnemy()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
