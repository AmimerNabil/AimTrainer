using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoves : MonoBehaviour
{
    private float movementSpeed = 10.0f;
    public Rigidbody rigidBody;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.position += -transform.right * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidBody.position += transform.right * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigidBody.position += -transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidBody.position += transform.forward * Time.deltaTime * movementSpeed;
        }

    }
}
