// File Prologue
// Name: Jonathan Franklin
// Project: RandomList Extra Credit
// Date: March 30, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomList : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {
        ListGenerator();
	}

    // This unparameterized method provides a default value
    public void ListGenerator()
    {
        ListGenerator(5);
    }

    // This function generates a list of random numbers of size determined by the supplied argument.
    public List<int> ListGenerator (int co)
    {
        int count = co;
        List<int> numbers = new List<int>(count);

        for (int i = 0; i < count; i++)
        {
            numbers.Add(Random.Range(0,100));
        }

        return numbers;
    }
}
