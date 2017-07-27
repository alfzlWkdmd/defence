using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymake : MonoBehaviour {
    private int start;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
        {
            start = 1;
        }
	}
}
