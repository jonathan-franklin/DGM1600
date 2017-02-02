// File Prologue
// Name: Jonathan Franklin
// Project: Variables
// Date: February 2, 2017


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;

namespace VariablesAssignment
{
	class MainClass
	{
		/* In this method, we will declare a number of variables with 
		 * varying data types. All of these variables can be changed
		 * and manipulated over the course of program execution. This
		 * is what separates a variable from a constant (const), which
		 * is declared and then is unable to be changed after that point. */

		public static void Main (string[] args)
		{
			/* To begin, we have here an int data type. An int data type
			 * represents an integer, positive or negative. Pretty
			 * straightforward. */
			int num01 = 0;

			/* Next, we have a double. The double can hold a 64-bit 
			 * floating-point decimal. */
			double num02 = 1.2;

			/* Next, we have a float. The float can hold a 32-bit
			 * floating-point decimal. */
			float num03 = 3.1f;

			/* Next, we have a char. The char can hold a single alpha-
			 * numeric character value. Specifically, char is a numeric
			 * data type that is used to hold Unicode values, which can
			 * represent most characters in most languages. Chars are 
			 * the building blocks of strings. */
			char char01 = 'A';

			/* A bool data type holds a true or false value, comparable
			 * to the on(1) or off(0) state of a transister. */
			bool bool01 = true;

			/* All the previous variables are explicitly declared, which
			 * is to say that their data type is explicitely stated in their
			 * declaration. For example, in "int num01 =0;", variable num01
			 * is explicitly declared as an int(integer) data type. The var
			 * operater is used to implicitely declare values. The system
			 * will decide the appropriate data type with which to assign
			 * our variable num04. NOTE: When using var, the variable 
			 * MUST BE INITIALIZED. */
			var num04 = 3;

			Console.WriteLine ("Hello! Today I will show you a number of variables." +
				" Press a key.");
			Console.ReadLine ();
			Console.WriteLine ("First we have an int. The value of this int is an integer, " +
				num01 + ". Press enter.");
			Console.ReadLine ();
			Console.WriteLine ("Now we have a double, which is a 64-bit floating point. " +
				"Our double is " + num02 + ". Press enter.");
			Console.ReadLine ();
			Console.WriteLine ("Now, let's move onto the float. Floats are 32-bit floating " +
				"points. Our floating point value is " + num03 + ". Press enter.");
			Console.ReadLine ();
			Console.WriteLine ("Next we have a char. This represents a single Unicode" +
			" character value. Our char is " + char01 + ". Press enter.");
			Console.ReadLine ();
			Console.WriteLine ("Finally, we have a bool. This represents either a true" +
				" or a false value. Our bool is valued " + bool01 + ". Press enter " +
				"to end this program.");
			Console.ReadLine ();
		}
	}
}
