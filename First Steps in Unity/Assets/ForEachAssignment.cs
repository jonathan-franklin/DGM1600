using UnityEngine;
using System.Collections;

public class ForEachAssignment : MonoBehaviour 
{
	public List<string> animals;

	// Use this for initialization
	void Start () 
	{
	foreach (string animal in animals)
	{
		print (animal);
	}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
