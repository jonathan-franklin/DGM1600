using UnityEngine;
using System.Collections;

public class move : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		// If left arrow is pressed, move object -.5 units on x axis.
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			gameObject.transform.Translate (-.5f, 0, 0);
		}

		// If up arrow is pressed, move object .5 units on y axis.
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			gameObject.transform.Translate (0, .5f, 0);
		}

		// If right arrow is pressed, move object .5 units on x axis.
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			gameObject.transform.Translate (.5f, 0, 0);
		}

		// If down arrow is pressed, move object -.5 units on y axis.
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			gameObject.transform.Translate (0, -.5f, 0);
		}

	}

}
