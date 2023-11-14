using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro:

public class DétecterCollisions : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);

        if (Input.GetKeyUp(KeyCode.Escape))
            Application.Quit();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "box1") 
        {
            Destroy(collision.gameObject);
        
        }
        
    }
}
