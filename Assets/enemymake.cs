using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymake : MonoBehaviour {
    private int i;
    public GameObject Enemy;
    void SpawnEnemy()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
    void Count()
    {
        i = i + 1;
    }
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 1, 1);
        InvokeRepeating("Count", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        if (i==10)
        {
            Time.timeScale=0.0f;
        }

    }
}
