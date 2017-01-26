using UnityEngine;
using System.Collections;

// This class will change the color of applicable objects when certain keys are pressed.
public class changeColor : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		// If the R key is pressed, change the color of the object to red.
		if (Input.GetKeyDown (KeyCode.R))
			GetComponent<Renderer> ().material.color = Color.red;

		// If the C key is pressed, change the color of the object to cyan.
		if (Input.GetKeyDown (KeyCode.C))
			GetComponent<Renderer> ().material.color = Color.cyan;

		// If the M key is pressed, change the color of the object to magenta.
		if (Input.GetKeyDown (KeyCode.M))
			GetComponent<Renderer> ().material.color = Color.magenta;

		// If the G key is pressed, change the color of the object to green.
		if (Input.GetKeyDown (KeyCode.G))
			GetComponent<Renderer> ().material.color = Color.green;
		
		// If the B key is pressed, change the color of the object to blue.
		if (Input.GetKeyDown (KeyCode.B))
			GetComponent<Renderer> ().material.color = Color.blue;
		
		// If the Esc key is pressed, change the color of the object to yellow.
		if (Input.GetKeyDown (KeyCode.Escape))
			GetComponent<Renderer> ().material.color = Color.yellow;

		// If the space bar is pressed, change the color of the object to black.
		if (Input.GetKeyDown (KeyCode.Space))
			GetComponent<Renderer> ().material.color = Color.black;

		// If the Delete key is pressed, change the color of the object to white.
		if (Input.GetKeyDown (KeyCode.Delete))
			GetComponent<Renderer> ().material.color = Color.white;
		}
}
