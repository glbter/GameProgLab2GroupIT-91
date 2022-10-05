using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public GameObject gameObject;
    private UICounter c;

    private void OnTriggerEnter(Collider other)
    {
        c = FindObjectOfType<UICounter>();

        if (other.tag == "Player")
        {
            c.AddPoint();
        }
            
        Destroy(gameObject);
    }
}
