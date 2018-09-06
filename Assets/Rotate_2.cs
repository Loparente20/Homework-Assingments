using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_2 : MonoBehaviour {


            public float turnSpeed = 50f;


    void Update()
    {


      
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}


