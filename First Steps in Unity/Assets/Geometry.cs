// File Prologue
// Name: Jonathan Franklin
// Project: Math Operators
// Date: February 7, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using UnityEngine;
using System;

/* IN ORDER TO USE THIS PROGRAM IN UNITY, YOU MUST CHANGE THE VARIABLE VALUES IN THE
 * UNITY INSPECTOR. THE SCRIPT IS BOUND TO THE SPHERE.  The five input variables are
 * public for this reason. */

public class Geometry : MonoBehaviour
{
    // Setting class constants
    private const double pi = Math.PI;
    private const double sphereVolMultiplier = (4 / 3);
    private const int radiusExponent = 2;
    private const int radiusSphereExponent = 3;
    private const int radiusMultiplier = 2;
    private const int triAreaDivider = 2;

    // Setting class variables
    public int triBase;
    public int height;
    public int radius;
    public int length;
    public int width;
    private double circleDiameter;
    private double circleArea;
    private double circleCircumference;
    private double rectangleArea;
    private double rectanglePerimeter;
    private double triArea;
    private double sphereVolume;

    // Un-parameterized constructor
    public Geometry()
    {
        triBase = 0;
        height = 0;
        radius = 0;
        length = 0;
        width = 0;
        circleDiameter = 0;
        circleArea = 0;
        circleCircumference = 0;
        rectangleArea = 0;
        rectanglePerimeter = 0;
        triArea = 0;
        sphereVolume = 0;
    }

    // Parameterized constructor in case script is modified for user input later
    public Geometry(int tb, int hg, int rd, int lg, int wd,
        double cd, double ca, double cc, double ra, double rp,
        double ta, double sv)
    {
        triBase = tb;
        height = hg;
        radius = rd;
        length = lg;
        width = wd;
        circleDiameter = cd;
        circleArea = ca;
        circleCircumference = cc;
        rectangleArea = ra;
        rectanglePerimeter = rp;
        triArea = ta;
        sphereVolume = sv;
    }

    // Run at the start of the program
    void Start()
    {
        print("In order to use this script, input variables in the Unity Inspector, then re-play.");
        print("The area of a circle with a radius of " + radius + " is " + areaCircle() + ".\n");
        print("The diameter of a circle with a radius of " + radius + " is " + diameterCircle() + ".\n");
        print("The circumference of a circle with a radius of " + radius + " is " + circumferenceCircle() + ".\n");
        print("The volume of a sphere with a radius of " + radius + " is " + volumeSphere() + ".\n");
        print("The perimeter of a rectangle with a length of " + length + " and a width of " + width + " is " + perimeterRectangle() + ".\n");
        print("The area of a rectangle with a length of " + length + " and a width of " + width + " is " + areaRectangle() + ".\n");
        print("The area of a triangle with a base of " + triBase + " and a height of " + height + " is " + areaTriangle() + ".\n");
    }

    /* Over the next several methods, you can see the implementation of many kinds of mathematical operations. These include addition (+),
     * subtraction (-), multiplication (*), division (/), parenthesis (()), and exponents (Math.Pow). The original formulas will be commented
     * next to their corresponding equation. */

    // This method calculates the area of a circle.
    public double areaCircle()
    {
        circleArea = (Math.Pow(radius, radiusExponent)) * pi; // A = (r ^ 2) * pi
		return circleArea;
	}

	// This method calculates the diameter of a circle.
	public double diameterCircle ()
	{
		circleDiameter = radius * radiusMultiplier; // d = 2r
		return circleDiameter;
	}

	// This method calculates the circumference of a circle.
	public double circumferenceCircle ()
	{
		circleCircumference = circleDiameter * pi; // c = pi * d, OR c = 2 * pi * r
		return circleCircumference;
	}

	// This method calculates the volume of a sphere.
	public double volumeSphere ()
	{
		sphereVolume = sphereVolMultiplier * pi * (Math.Pow(radius, radiusSphereExponent)); // (4/3) * pi * (r^3)
		return sphereVolume;
	}

	// This method calculates the perimeter of a rectangle.
	public double perimeterRectangle ()
	{
		rectanglePerimeter = length + length + width + width; // p = l + l + w +w
		return rectanglePerimeter;
	}

	// This method calculates the area of a rectangle.
	public double areaRectangle ()
	{
		rectangleArea = length * width; // A = l * w
		return rectangleArea;
	}

	// This method calculates the area of a triangle.
	public double areaTriangle ()
	{
		triArea = (triBase * height) / triAreaDivider; // A = (b * h) / 2
		return triArea;
	}
}
