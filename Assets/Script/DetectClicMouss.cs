using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClicMouss : MonoBehaviour
{
    public Color[] colors;
    public bool isClicked = false;

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

    }

}
