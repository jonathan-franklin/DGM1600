// File Prologue
// Name: Jonathan Franklin
// Project: Switch Assignment
// Date: February 16, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

/// <summary>
/// The purpose of this script is to demonstrate the use of switch statements through
/// explanation and example.
/// </summary>
/// 


using UnityEngine;
using System.Collections;

/* The switch statement allows us test for a series of values. Essentially, if the assigned
 * value matches a case within the switch, a specific set of instructions will run before
 * breaking. If no cases are matched, a default case is run. Switches are useful as they can
 * be much more resource efficient than if-else blocks, at least when testing five or more conditions.
 * And also depending on the language, compiler, and/or interpreter. */

public class SwitchAssignment : MonoBehaviour 
{
    // Declaring class variables
    private int time = 15;
    private int month = 12;
    private int age = 20;
    private string color = "cyan";
    private string grief = "acceptance";

	// Use this for initialization
	void Start () 
	{
        // This switch block lists my usual weekday activities. Use 24-hour time.
	    switch (time)
        {
            case 9:
                print("Wake up");
                break;
            case 10:
                print("Get yourself to class.");
                break;
            case 13:
                print("Eat some gorram lunch.");
                break;
            case 18:
                print("Eat some din, or you'll regret it later.");
                break;
            case 21:
                print("Go to work. That is all.");
                break;
            case 2:
                print("Sleeeeeep");
                break;
            default:
                print("You float through the universal void on a speck of chaos.");
                break;
        }

        // This switch block lists a holiday for every month.
        switch (month)
        {
            case 1:
                print("New Years Day");
                break;
            case 2:
                print("Valentine's Day");
                break;
            case 3:
                print("St. Patrick's Day");
                break;
            case 4:
                print("Easter");
                break;
            case 5:
                print("Memorial Day");
                break;
            case 6:
                print("Flag Day");
                break;
            case 7:
                print("Independence Day");
                break;
            case 8:
                print("International Beer Day");
                break;
            case 9:
                print("Labor Day");
                break;
            case 10:
                print("Halloween");
                break;
            case 11:
                print("Thanksgiving");
                break;
            case 12:
                print("Kwanzaa");
                break;
            default:
                print("Stickin' with the Gregorian Calendar here.");
                break;                        
        }

        // This switch block describes some important ages.
        switch (age)
        {
            case 18:
                print("Congratulations! You can vote! And be adult (if you really want).");
                break;
            case 19:
                print("You can smoke. Don't start, if you can help it.");
                break;
            case 21:
                print("You can do an alcohol. Legally. Don't do anything too stupid.");
                break;
            case 62:
                print("You can start pulling from social security!");
                break;
            case 66:
                print("You are full retirement age under Social Security!");
                break;
            default:
                print("You continue your march to the grave. Godspeed.");
                break;
        }

        // This switch block provides examples of objects holding certain colors.
        switch (color)
        {
            case "red":
                print("The color of the rising blood moon.");
                break;
            case "blue":
                print("The color of a deep and turbulent ocean.");
                break;
            case "green":
                print("The color of a dense, ancient forest.");
                break;
            case "purple":
                print("The color of a corrupt royal family");
                break;
            case "cyan":
                print("Jon's favorite color.");
                break;
            case "black":
                print("The color of a high, eclipsed sun.");
                break;
            default:
                print("That color isn't real.");
                break;
        }

        // This switch block outlines the five stages of grief.
        switch (grief)
        {
            case "denial":
                print("Denial, the first stage of grief. You deny the reality of the situation");
                break;
            case "anger":
                print("Anger, the second stage of grief. Reality and pain return, and you resent the subject of grief.");
                break;
            case "bargaining":
                print("Bargaining, the third stage of grief. The need to regain control.");
                break;
            case "depression":
                print("Depression, the fourth stage of grief. Sadness, regret, and worry.");
                break;
            case "acceptance":
                print("Acceptance, the fifth stage of grief. Withdrawl, and the making of peace.");
                break;
        }
	}
}
