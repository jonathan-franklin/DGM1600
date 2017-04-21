using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public Text target;
    public Text functionInputField;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    // This method checks if the user input is equivalent to the target number when the enter button is pressed.
   /* public void CheckMath ()
    {
        int input = int.Parse(functionInputField.text);
        int targetInt = int.Parse(target.text);
        bool isCorrect = false;
        if (input == targetInt)
        {
            isCorrect = true;
        }

        print(isCorrect);
    } */
}
