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
        float xVal = Random.Range(-4.2f, 4.2f);
        float zVal = Random.Range(-4.2f, 4.2f);
        Instantiate(cubePrefab, new Vector3(xVal,0.5f,zVal),Quaternion.identity);
    }
   
}
