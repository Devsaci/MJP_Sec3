using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClicMouss : MonoBehaviour
{
    public Color[] colors;
    public bool isClicked = false;

    private void OnMouseDown()
    {
        
    }

    private void OnMouseOver()
    {
        if (! isClicked)
        {
            GetComponent<Renderer>().material.color = colors[0];
        }
    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = colors[1];
    }
    private void OnMouseUp()
    {
        isClicked = true;   
        GetComponent<Renderer>().material.color = colors[2];
    }



}
