using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectKeyBoard : MonoBehaviour
{
 

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back);
        }

    }
}
