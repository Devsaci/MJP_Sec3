using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectKeyBoard : MonoBehaviour
{
 

    
    void Update()
    {
        transform.Rotate(Vector3.right * 15 * Time.deltaTime);
    }
}
