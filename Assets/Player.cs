using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int MyLife = 10;
	void Start () {
		
	}
	
	void Update () {
        Debug.Log(EnemyList.targetlist.Count);
    }
}
