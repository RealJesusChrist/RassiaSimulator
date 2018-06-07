using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RegionClick : MonoBehaviour
{
    string name;
    public GameObject kekeke;
    private void Start()
    {
        name = gameObject.name;
    }
    public void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (kekeke.GetComponent<body>().selected != name)
            {
                kekeke.GetComponent<body>().selected = name;
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else
            {
                kekeke.GetComponent<body>().selected = "Fuck No";
            }
        }
    }
    void Update()
    {
        if (kekeke.GetComponent<body>().selected != name)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }
    }
}
