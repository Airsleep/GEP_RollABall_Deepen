using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Vector3 v3XForce;
    [SerializeField]
    Vector3 v3ZForce;

    [SerializeField]
    KeyCode keyUpArrow;
    [SerializeField]
    KeyCode keyDownArrow;
    [SerializeField]
    KeyCode keyRightArrow;
    [SerializeField]
    KeyCode keyLeftArrow;

    void FixedUpdate()
    {
        if (Input.GetKey(keyUpArrow))
        {
            GetComponent<Rigidbody>().velocity += v3ZForce;
        }

        if (Input.GetKey(keyDownArrow))
        {
            GetComponent<Rigidbody>().velocity -= v3ZForce;
        }

        if (Input.GetKey(keyRightArrow))
        {
            GetComponent<Rigidbody>().velocity += v3XForce;
        }

        if (Input.GetKey(keyLeftArrow))
        {
            GetComponent<Rigidbody>().velocity -= v3XForce;
        }
    }
}
