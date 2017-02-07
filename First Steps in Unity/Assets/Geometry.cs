using UnityEngine;
using System;

public class Geometry : MonoBehaviour 
{
	private double pi = Math.PI; 
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// This method calculates the area of a circle.
	public double areaCircle (double rd)
	{
		private double radius = rd;
		private double circleArea; // Area of a circle.
		private const int radiusExponent = 2;

		circleArea = (radius ^ radiusExponent) * pi; 
		return circleArea;
	}

	// This method calculates the diameter of a circle.
	public double diameterCircle (double rd)
	{
		private double radius = rd;
		private double diameter;
		private const int radiusMultiplier;

		diameter = radius * radiusMultiplier;
		return diameter;
	}

	// This method calculates the circumference of a circle.
	public double circumferenceCircle (double rd)
	{
		private double radius = rd;
		private double circumference;

		circumference = Geometry.diameter(radius) * pi;
		return circumference;
	}

	// This method calculates the volume of a sphere.
	public double volumeSphere (double rd)
	{
		private double radius = rd;
		private double radiusExponent = 3;
		private double volumeMultiplier = (4/3);
		private double volume;

		volume = volumeMultiplier * pi * (radius ^ radiusExponent);
		return volume;
	}

	// This method calculates the perimeter of a rectangle.
	public int perimeterRectangle (int lg, int wd)
	{
		private int length = lg;
		private int width = wd;
		private int perimeter;

		perimeter = length + length + width + width;
		return perimeter;
	}

	// This method calculates the area of a rectangle.
	public double areaRectangle (int lg, int wd)
	{
		private int length = lg;
		private int width = wd;
		private double area;

		area = length * width;
		return area;
	}

	// This method calculates the area of a triangle.
	public double areaTriangle (int bs, int ht)
	{
		private int triBase = bs;
		private int height = ht;
		private const int areaDivider = 2;
		private double area;

		area = (triBase * height) / areaDivider;
		return area;
	}
}
