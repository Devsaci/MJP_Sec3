using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpowner : MonoBehaviour
{

    public GameObject cubePrefab;


    void Start()
    {
        
    }

    public void CreatCube()
    {
        float xval = Random.Range(-4.2f, 4.2f);
        float zval = Random.Range(-4.2f, 4.2f);
        Instantiate(cubePrefab, new Vector3(),Quaternion.identity);
    }
   
}
