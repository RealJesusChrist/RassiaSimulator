using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : body
{
    public GameObject body;
    public bool baton = true;
    public void Button_Onclick()
    {
        baton = !baton;
        month++;
        if (month == 13)
        {
            month = 1;
            year++;
        }
        time.text = 2018 + year + "." + month;
        body.GetComponent<body>().step = !body.GetComponent<body>().step;
    }
    byte year = 0;
    byte month = 1;
    public Text time;
    string a;

    void Start()
    {
        time.text = "2018.1";
    }



}

