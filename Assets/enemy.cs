using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    void Awake()
    {
        EnemyList.targetlist.Add(this.gameObject);
    }
    void update()
    {
        Debug.Log(EnemyList.targetlist.Count);
    }
}
