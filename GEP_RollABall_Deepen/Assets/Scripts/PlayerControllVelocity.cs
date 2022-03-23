using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3;

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3;
    }
}
