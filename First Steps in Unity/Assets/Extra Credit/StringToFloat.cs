// File Prologue
// Name: Jonathan Franklin
// Project: StringToFloat Extra Credit
// Date: March 31, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringToFloat : MonoBehaviour
{
    public string toBeConverted = "5";

    // Use this for initialization
    void Start()
    {
        print(StringFloat(toBeConverted));
    }

    // This method converts an inputed string into a float.
    public float StringFloat(string fl)
    {
        string toFloat = fl;
        float fromString = float.Parse(toFloat);
        return fromString;
    }
}
