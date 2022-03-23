using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCube : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
