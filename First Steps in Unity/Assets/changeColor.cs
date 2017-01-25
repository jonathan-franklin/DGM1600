using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        //If "r" key is pressed, object color will be changed to red.
	    if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }	

        //If "g" key is pressed, object color will be changed to green.
        if(Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        
        //If "m" key is pressed, object color will be changed to magenta.
        if(Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }

        //If "c" key is pressed, object color will be changed to clear.
        if(Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.clear;
        }
	}
}
