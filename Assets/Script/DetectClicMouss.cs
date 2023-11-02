using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClicMouss : MonoBehaviour
{
    public Color[] colors;

    private void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = colors[0];
    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = colors[1];
    }
    private void OnMouseUp()
    {
        GetComponent<Renderer>().material.color = colors[2];
    }



}
