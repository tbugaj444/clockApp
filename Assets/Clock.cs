using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;// For DateTime
using UnityEngine.UI;
using TMPro;

public class Clock : MonoBehaviour {
    public Transform secondsTransform, minutesTransform, hoursTransform;

    public TextMeshProUGUI text;

    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;

    public timeScript timeKeeper;

    
    // Use this for initialization
    void Start () {
        //Debug.Log(DateTime.Now.Hour);
        timeKeeper = GameObject.Find("Scroll View").GetComponent(typeof(timeScript)) as timeScript;       
    }

    // Update is called once per frame
    void Update()
    {
      
        DateTime adjustedTime = DateTime.Now;
       
        UpdateDiscrete(adjustedTime);

        text.text = UpdateDate(adjustedTime).ToShortDateString();
    }

    // Update is called once per frame
    void UpdateDiscrete(DateTime t)
    {
    
        hoursTransform.localRotation =
            Quaternion.Euler((t = t.AddHours(timeKeeper.getHour())).Hour * degreesPerHour, 0f, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler((t = t.AddMinutes(timeKeeper.getMin())).Minute * degreesPerMinute, 0f, 0f);
        secondsTransform.localRotation =
            Quaternion.Euler((t = t.AddSeconds(timeKeeper.getSec())).Second * degreesPerSecond, 0f, 0f);

    }
    private DateTime UpdateDate(DateTime t)
    {
        t = t.AddDays(timeKeeper.getDay());
        t = t.AddMonths(timeKeeper.getMonth());
        t = t.AddYears(timeKeeper.getYear());
        return t;
    }

}
