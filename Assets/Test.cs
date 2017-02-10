using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		Vector3 next = transform.position;
		next.x += 1f * Time.deltaTime;
		transform.position = next;
	}
}
