using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiplyFunction : MonoBehaviour 
{
	void Update ()
	{
		Multiply();
	}

	public void Multiply ()
	{
		// Declaring function variables.
		float inputOne = 0;
		float inputTwo = 0;
		float inputThree = 0;
		float inputProduct = 0;

		GameObject InputFieldOne = GameObject.Find("QuickPractice.Canvas.InputFieldOne");
		InputField InputFieldOneS = InputFieldOne.GetComponent<InputField>();

		GameObject InputFieldTwo = GameObject.Find("QuickPractice.Canvas.InputFieldTwo");
		InputField InputFieldTwoS = InputFieldTwo.GetComponent<InputField>();

		GameObject InputFieldThree = GameObject.Find("QuickPractice.Canvas.InputFieldThree");
		InputField InputFieldThreeS = InputFieldThree.GetComponent<InputField>();

		inputOne = float.Parse(InputFieldOneS.text);
		inputTwo = float.Parse(InputFieldTwoS.text);
		inputThree = float.Parse(InputFieldThreeS.text);

		inputProduct = inputOne * inputTwo * inputThree;

		print("Your three inputted variables multiplied together equals" + inputProduct + ".");
	}

}
