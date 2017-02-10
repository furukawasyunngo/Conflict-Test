using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
    public GameObject cube;

	// Update is called once per frame
	void Update () 
	{
		Quaternion now = transform.rotation;
		Quaternion rot = Quaternion.AngleAxis(90f*Time.deltaTime, Vector3.up);
		rot = rot*now;
		transform.rotation = rot;
        Instantiate(cube);
        Instantiate(cube, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity);
	}
}
