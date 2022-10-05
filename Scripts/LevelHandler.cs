using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    private UICounter counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        counter = FindObjectOfType<UICounter>();

        Debug.Log("entered");
        if (c.tag == "Player" && counter.Point >= 2)
        {
            SceneManager.LoadScene("Labirynt"); //"Labirynt"
        }
    }
}
