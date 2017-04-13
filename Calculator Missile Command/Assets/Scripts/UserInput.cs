using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public InputField functionInputField;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickNumberButton(string numberClicked)
    {
        string currentString = functionInputField.text;
        string newString = currentString + numberClicked; ;

        functionInputField.text = newString;

    }
}
