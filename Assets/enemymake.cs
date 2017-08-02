using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymake : MonoBehaviour {
    public int MyLife=10;
    public GameObject Enemy;
    void SpawnEnemy()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
    void LiveDown()
    {
        MyLife--;
    }
  
	void Start () {
        InvokeRepeating("SpawnEnemy", 1, 1);
        InvokeRepeating("LiveDown", 1, 1);
	}
	
	void Update () {
        
        if (MyLife==0)
        {
            Time.timeScale=0.0f;
        }

    }
}
