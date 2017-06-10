// File Prologue
// Name: Jonathan Franklin
// Project: MultiplicationTable Extra Credit
// Date: April 2, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        Multiplication(Random.Range(0, 12));
	}
	
    // This method creates a multiplication table for the inputted argument. 
    public void Multiplication (float nu)
    {
        float number = nu;
        float product;

        List<float> products = new List<float>();

        // Multiply argument by the counter value and add to list, products.
        for (int i = 0; i < 13; i++)
        {
            product = number * i;
            products.Add(product);
        }

        // Print each item in the list, products.
        foreach (object o in products)
        {
            print(o);
        }
    }
}
