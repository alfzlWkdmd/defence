using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMake : MonoBehaviour {
    public float makeTime;
    public GameObject Enemy;
    
            
    void SpawnEnemy()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
    void LiveDown()
    {
        Player.Life--;
    }
  
	void Start () {
        InvokeRepeating("SpawnEnemy", makeTime, 1);
        InvokeRepeating("LiveDown", makeTime, 1);
	}
	
	void Update () {
        
        if (Player.Life==0)
        {
            Time.timeScale=0.0f;
        }

    }
}
