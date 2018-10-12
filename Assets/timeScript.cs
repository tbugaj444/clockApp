using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class timeScript : MonoBehaviour {
    public InputField hour;
    public InputField min;
    public InputField sec;
    public InputField day;
    public InputField month;
    public InputField year;


      int h=0;
      int m=0;
      int s=0;

      int da=0;
      int mo=0;
      int ye=0;





    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {

        string hTemp = hour.text;
        h = int.Parse(hTemp);
        
        string mTemp = min.text;
        m= int.Parse(mTemp);

        string sTemp = sec.text;
        s= int.Parse(sTemp);

        string dTemp = day.text;
        da = int.Parse(dTemp);

        string moTemp = month.text;
        mo = int.Parse(moTemp);

        string yTemp = year.text;
        ye = int.Parse(yTemp);

    }
    public int getHour() {

        return h;

    }
    public int getMin()
    {

        return m;

    }
    public int getDay()
    {

        return da;

    }
    public int getMonth()
    {

        return mo;

    }
    public int getSec()
    {

        return s;

    }
    public int getYear()
    {

        return ye;

    }


}
