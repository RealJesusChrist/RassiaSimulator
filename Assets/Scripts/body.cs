using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour {

    public string selected="Fuck No";
    public bool step=true;
    bool step2=true;


    private void Start()
    {
    }

    void Update ()
    {
        if (step != step2)
        {
            step2 = step;

        }
	}
}
