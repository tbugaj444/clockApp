using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class timeModifier : MonoBehaviour {
    public InputField num;

    int i;
    
    // Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {        


        string ti = num.text;
        i = int.Parse(ti);
		
	}
    public void inc() {
            i++;
            num.text = i.ToString();
            
    }
    public void dec() {
            i--;
            num.text = i.ToString();
    }

    
}
