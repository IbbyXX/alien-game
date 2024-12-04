using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //adds text to console
        Debug.Log("hello world");
        Debug.Log("hello worl");
        Debug.Log("hello wor");
        
    }

    // Update is called once per frame
    void Update()
    {
        //spams text in console


        //smoothly moves image
        transform.Translate(0.0005f, 0, 0);
    }
}
