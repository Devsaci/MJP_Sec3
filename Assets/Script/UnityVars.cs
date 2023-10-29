using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityVars : MonoBehaviour
{
    // Variable
    public GameObject go;
    public Transform goTransform;
    public Vector3 goPos;

    // Start is called before the first frame update
    void Start()
    {
        goPos = goTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
