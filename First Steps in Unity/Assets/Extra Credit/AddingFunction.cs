// File Prologue
// Name: Jonathan Franklin
// Project: AddingFunction Extra Credit
// Date: March 31, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    // This method adds two float parameters together and returns the sum.
    public float Addition (float ad, float ac)
    {
        float addOne = ad;
        float addTwo = ac;
        float sum = addOne + addTwo;

        return sum;
    }
}
