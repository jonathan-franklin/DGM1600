using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        TargetMovement();
    }

    public void TargetMovement()
    {
        transform.Translate(Vector3.down, Space.World);
    }
}
