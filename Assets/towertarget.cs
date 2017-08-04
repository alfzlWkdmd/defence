using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towertarget : MonoBehaviour {
    private Transform Target;
    private enemy TargetEnemy;

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int[] Enemy={};

        foreach (int Target in Enemy) ;
	}
}
