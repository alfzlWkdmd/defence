using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymake : MonoBehaviour {
    void SpawnEnemy()
    {
        Instantiate(enemy);
    }
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
