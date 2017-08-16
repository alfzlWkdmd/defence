using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static int Life;
    public int MyLife = 10;
	
    void Awake()
    {
        Life = MyLife;
    }
	
	void Update () {
        Debug.Log(EnemyList.targetlist.Count);
    }
}
