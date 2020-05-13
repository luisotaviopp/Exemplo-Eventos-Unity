using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJogador : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float walkingSpeed = 1f;

    void LateUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3 (0, rotationSpeed*Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed*Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, walkingSpeed*Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -walkingSpeed * Time.deltaTime));
        }
    }
}
