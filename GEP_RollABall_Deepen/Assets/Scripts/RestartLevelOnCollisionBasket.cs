using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollisionBasket : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    string strSceneName;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            SceneManager.LoadScene(strSceneName);
        }
    }
}
