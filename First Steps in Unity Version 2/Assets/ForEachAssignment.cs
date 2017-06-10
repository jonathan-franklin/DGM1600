using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForEachAssignment : MonoBehaviour 
{
	public List<string> animals;
	public List<string> dogs;
	public List<string> cats;

	// Use this for initialization
	void Start () 
	{
		foreach (string animal in animals)
		{
			print (animal);

			switch (animal) 
			{
				case "cat":
					cats.Add (animal);
					animals.Remove (animal);
					break;

				case "dog":
					dogs.Add (animal);
					animals.Remove (animal);
					break;

				default:
					break;
			}
		}

		foreach (string removeAnimal in animals)
		{
			print (removeAnimal);

			switch (removeAnimal)
			{
				case "cat":
					cats.Remove (removeAnimal);
					break;

				case "dog":
					dogs.Remove (removeAnimal);
					break;

				default:
					break;	
			}
		}
	}
}
