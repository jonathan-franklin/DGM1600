// File Prologue
// Name: Jonathan Franklin
// Project: FloatMultiplication Extra Credit
// Date: March 30, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatMultiplication : MonoBehaviour
{
    // Declaring class variables
    public float firstMultiplier;
    public float secondMultiplier;
    public float thirdMultiplier;
    private float product;

    // Unparameterized Constructor
    public FloatMultiplication ()
    {
        firstMultiplier = 0;
        secondMultiplier = 0;
        thirdMultiplier = 0;
        product = 0;
    }

    // Use this for initialization
    void Start ()
    {
        FloatMultiplier(); // Call FloatMultiplier at the start of the program.
	}
	
    // This method solves for the product of the three multiplier variables.
    public void FloatMultiplier ()
    {
        product = firstMultiplier * secondMultiplier * thirdMultiplier;
        print("The product of " + firstMultiplier + " and " + secondMultiplier + " and " + thirdMultiplier + " equals " + product);
    }

}
