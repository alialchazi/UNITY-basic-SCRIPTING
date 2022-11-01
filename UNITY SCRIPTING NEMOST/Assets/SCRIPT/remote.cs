using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remote : MonoBehaviour
{
    float NE = 0.01f;
    float X, Y, Z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print("hello");
        //print("Hello");
        //print(transform.position);


        X = transform.position.x;
        Y = transform.position.y;
        Z = transform.position.z;

        if (Input.GetKey(KeyCode.W))
        {
            //print("W");

            transform.position = new Vector3(X, Y + NE, Z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(X, Y - NE, Z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(X - NE, Y, Z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(X + NE, Y, Z);
        }
    }
}
