using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DéclenchFonctionTime : MonoBehaviour
{

    public float speed = 3.0f;
    public float rotationSpeed = 60.0f;
    public TMP_Text text;
    int nbColis = 0;


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


        if (collision.gameObject.tag == "box")
        {
            Destroy(collision.gameObject);


        }
    }



}
