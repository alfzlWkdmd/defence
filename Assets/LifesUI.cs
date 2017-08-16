using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifesUI : MonoBehaviour {
   
    public Text LifesText;
    void Start()
    {
     
    }
	
	void Update () {
        LifesText.text = Player.Life.ToString()+"Lifes";
		}
}
