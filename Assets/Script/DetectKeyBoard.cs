using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectKeyBoard : MonoBehaviour
{


    public float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))

            MoveInDirection(Vector3.forward);

        if (Input.GetKey(KeyCode.DownArrow))

            MoveInDirection(Vector3.back);

        if (Input.GetKey(KeyCode.RightArrow))

            MoveInDirection(Vector3.right);

        if (Input.GetKey(KeyCode.LeftArrow))

            MoveInDirection(Vector3.left);


    }


    public void MoveInDirection(Vector3 dir)
    {
        transform.Translate(dir * Time.deltaTime * speed);
    }

}
