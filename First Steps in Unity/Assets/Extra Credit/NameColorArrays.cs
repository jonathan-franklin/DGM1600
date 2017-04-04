// File Prologue
// Name: Jonathan Franklin
// Project: NameColorArrays Extra Credit
// Date: March 30, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameColorArrays : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        Arrays();
	}
	
    // Creates a randomized sentence in the structure "[name]'s favorite color is [color]."
    public void Arrays ()
    {
        string[] names = { "Sonya", "Schnell", "Chanelle", "Belial", "Jefferson" };
        string[] colors = { "cyan", "salmon", "beige", "magenta", "yellow" };

        print(names[Random.Range(0, names.Length)] + "'s favorite color is " + colors[Random.Range(0, colors.Length)] + ".");
    }

}
