using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBtton : MonoBehaviour {
    Player player;
    void Start()
    {
        player = GetComponent<Player>();
    }
	public void KillLastEnemy()
    {
        if(EnemyList.targetlist.Count<=0)
        {
            return;
        }
        Destroy(EnemyList.targetlist[0].gameObject);
        EnemyList.targetlist.RemoveAt(0);
        player.MyLife++;
    }
}
