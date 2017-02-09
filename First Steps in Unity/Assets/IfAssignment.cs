using UnityEngine;
using System.Collections;

public class IfAssignment : MonoBehaviour 
{
	// Declaring class variables
	private int fancyInteger = 5;
	private float crappyFloat = 10.0f;
	private string obsceneString = "Halp";
	private bool amIFalse = false;

	/* Time for a brief explanation of if, else, and else if statements.
	 * An if-statement is, at its most basic, and check for truth. The
	 * if statement will check the comparison made within its parameters,
	 * and execute if that comparison is true. If it is not true, it will
	 * execute the following else statement, if one is provided. Else-if 
	 * provides a means of stacking else statements, so that you can have multiple
	 * else checks following a single if statement. */

	// Use this for initialization
	void Start () 
	{

		if (fancyInteger == 4)
		{
			print("You are indeed a fancy integer.");
		}
		else if (fancyInteger < 4)
		{
			print("You are an inferior int. Leave my sight.");
		}
		else
		{
			print("You are above me.");
		}

		if (crappyFloat == 7.0f)
		{
			print("You live up to your name, crappyFloat");
		}
		else if (crappyFloat < 7.0f)
		{
			print("You're worse than anyone asked for. Come back when you're at least a 7.0f on the crappiness scale.");
		}
		else if (crappyFloat > 7.0f)
		{
			print("Look at you, you overachiever. I'm turning your sphere yellow. I mean gold.");
			GetComponent<Renderer> ().material.color = Color.yellow;
		}

		if (obsceneString == "shit" || obsceneString == "damn")
		{
			print("You're living up to all my expectations, you obscene you.");
		}
		else if (obsceneString == "fuck")
		{
			print("That's probably too far for this class");
		}
		else if (obsceneString == "Halp")
		{
			print("You've come to the right place. I will teach you how to do the swears.");
		}
		else
		{
			print("Keep it basic, this program is pretty rudimentary.");
		}

		if (amIFalse == true)
		{
			print("Stop it.");
		}
		else
		{
			print("STOP IT.");
		}
		
		if (fancyInteger == crappyFloat)
		{
			print("This isn't right. Actually, I suppose crappiness and fanciness are not mutually exclusive.");
		}
	}
}
