using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public InputField functionInputField;
    public int inputOne = 0;
    public int inputTwo = 0;
    public int currentInput = 0;
    public string currentOperator;
    public int result;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickNumberButton (string numberClicked)
    {
        string currentString = functionInputField.text;
        string newString = currentString + numberClicked;

        if (numberClicked == "1")
        {
            currentInput = currentInput * 10 + 1;
        }
        else if (numberClicked == "2")
        {
            currentInput = currentInput * 10 + 2;
        }
        else if (numberClicked == "3")
        {
            currentInput = currentInput * 10 + 3;
        }
        else if (numberClicked == "4")
        {
            currentInput = currentInput * 10 + 4;
        }
        else if (numberClicked == "5")
        {
            currentInput = currentInput * 10 + 5;
        }
        else if (numberClicked == "6")
        {
            currentInput = currentInput * 10 + 6;
        }
        else if (numberClicked == "7")
        {
            currentInput = currentInput * 10 + 7;
        }
        else if (numberClicked == "8")
        {
            currentInput = currentInput * 10 + 8;
        }
        else if (numberClicked == "9")
        {
            currentInput = currentInput * 10 + 9;
        }
        else if (numberClicked == "0")
        {
            currentInput = currentInput * 10;
        }
        else if (numberClicked == "+" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "+";
            currentInput = 0;
        }
        else if (numberClicked == "-" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "-";
            currentInput = 0;
        }
        else if (numberClicked == "*" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "*";
            currentInput = 0;
        }
        else if (numberClicked == "/" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "/";
            currentInput = 0;
        }
        else if (numberClicked == "%" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "%";
            currentInput = 0;
        }
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "+")
        {
            inputTwo = currentInput;
            result = inputOne + inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

                        newString = "" + result;
        }
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "-")
        {
            inputTwo = currentInput;
            result = inputOne - inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
        }
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "*")
        {
            inputTwo = currentInput;
            result = inputOne * inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
        }
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "/")
        {
            inputTwo = currentInput;
            result = inputOne / inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
        }
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "%")
        {
            inputTwo = currentInput;
            result = inputOne % inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
        }

        functionInputField.text = newString;
    }

}
