using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0.5F, 0);
        cube.transform.localScale = new Vector3(1, 1, 1);
        Instantiate(cube);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
