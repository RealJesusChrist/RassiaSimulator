using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    // Use this for initialization
    void Start()
    { }
    public GameObject obj;
    float d=2.7f, dd;
    float xpos, dx;
    float ypos, dy;
    public Camera cam;
// Update is called once per frame
void Update()
{
        dy= d*Input.GetAxis("Horizontal")/10;
        dx= d*Input.GetAxis("Vertical")/10;
        dd=-Input.GetAxis("Mouse ScrollWheel")/2;
        if (d + dd >= 0.5 && dd + d <= 3)
        {
            d += dd;
        }

        if(xpos- d < -3)
        {
            xpos = -3+d;
        }
        if (xpos + d >3)
        {
            xpos = 3-d;
        }
        if (ypos + 2*d > 6)
        {
            ypos = 6-2*d;
        }
        if (ypos - 2*d < -6)
        {
            ypos = -6+2*d;
        }

        if (xpos+dx-d>=-3 && xpos + dx + d <= 3)
        {
            xpos += dx;
        }
        if (ypos + dy - 2*d >= -6 && ypos + dy + 2*d <= 6)
        {
            ypos += dy;
        }
       
        obj.transform.position = new Vector3(ypos, xpos, -1);
        cam.orthographicSize = d;
    }
}