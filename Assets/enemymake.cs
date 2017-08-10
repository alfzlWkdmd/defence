using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMake : MonoBehaviour {
    public float makeTime;
    public GameObject Enemy;
    Player player;
    
            
    void SpawnEnemy()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
    void LiveDown()
    {
        player.MyLife--;
    }
  
	void Start () {
        player = GetComponent<Player>();
        InvokeRepeating("SpawnEnemy", makeTime, 1);
        InvokeRepeating("LiveDown", makeTime, 1);
	}
	
	void Update () {
        
        if (player.MyLife==0)
        {
            Time.timeScale=0.0f;
        }

    }
}
