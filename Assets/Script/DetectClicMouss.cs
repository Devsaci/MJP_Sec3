using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClicMouss : MonoBehaviour
{
    public Color[] colors;
    public bool isClicked = false;
    public float scrollSpeed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Renderer>().material.color = colors[0];
        }
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Renderer>().material.color = colors[1];
        }

        ////////////////////////////////////////////////////
       

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (Camera.main.fieldOfView <= 95)
                Camera.main.fieldOfView += scrollSpeed;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (Camera.main.fieldOfView >= 45)
                Camera.main.fieldOfView -= scrollSpeed;
        }
    }

}
