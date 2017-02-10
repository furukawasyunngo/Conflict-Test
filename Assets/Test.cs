using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	// Update is called once per frame
	void Update () 
	{
		Quaternion now = transform.rotation;
		Quaternion rot = Quaternion.AngleAxis(90f*Time.deltaTime, Vector3.up);
		rot = rot*now;
		transform.rotation = rot;
	}
}
