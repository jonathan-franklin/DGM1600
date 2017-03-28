using UnityEngine;
using System.Collections;

public class ArrayPractice : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Arrays();
	}
	
	public void Arrays ()
	{
		string[] names = {"Jim", "Julia", "Joseph", "Josephine", "Jorge"};
		string[] colors = {"red", "brown", "blue", "grey", "cyan"};

		print(names[Random.Range (0, names.Length)] + "'s unfavorite color is " + colors[Random.Range (0, colors.Length)]);
	}
}
