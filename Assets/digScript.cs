using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class digScript : MonoBehaviour {
    public TextMesh Time, Date;
    public timeScript timeKeeper;

	// Use this for initialization
	void Start () {
        timeKeeper = GameObject.Find("Scroll View").GetComponent(typeof(timeScript)) as timeScript;

    }

    // Update is called once per frame
    void Update () {
        DateTime t = DateTime.Now;
        t = t.AddHours(timeKeeper.getHour());
        t = t.AddMinutes(timeKeeper.getMin());
        t = t.AddSeconds(timeKeeper.getSec());
        t = t.AddDays(timeKeeper.getDay());
        t = t.AddMonths(timeKeeper.getMonth());
        t = t.AddYears(timeKeeper.getYear());


        Time.text = t.ToShortTimeString();
        Date.text = t.ToShortDateString();

    }
}
