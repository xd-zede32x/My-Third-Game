using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Carmower Car;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Car.Accelerate();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Car.RotateRith();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Car.RotateLeft();
        }
    }

}
