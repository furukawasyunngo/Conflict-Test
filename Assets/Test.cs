using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
    public GameObject cube;
    public GameObject tama;
    public GameObject capuseru;
    int rand;
    int time = 0;
	// Update is called once per frame
	void Update () 
	{
        time++;
		Quaternion now = transform.rotation;
		Quaternion rot = Quaternion.AngleAxis(90f*Time.deltaTime, Vector3.up);
		rot = rot*now;
		transform.rotation = rot;

        if (time == 180)
        {
            time = 0;
            rand = Random.Range(1, 3);
            if (rand == 1)
            {
                Instantiate(cube, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity);
                Instantiate(cube, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity);

            } else if (rand == 2)
            {
                Instantiate(tama, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity);
                Instantiate(tama, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity);
            } else if (rand == 3)
            {
                Instantiate(capuseru, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity);
                Instantiate(capuseru, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity);
            }
        }
	}

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
