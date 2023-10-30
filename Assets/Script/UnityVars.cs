using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityVars : MonoBehaviour
{
    // Variable
    public GameObject go;
    public Transform goTransform;
    public Vector3 goPos;
    public Renderer rend;
    public Material mat;
    public Collider col;

    // Start is called before the first frame update
    void Start()
    {
        goPos = goTransform.position;
        transform.position = goPos;
        rend = GetComponent<Renderer>();
        mat = rend.material;
        col = GetComponent<Collider>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
