using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

    public Material materialBlack;

	// Use this for initialization
	void Start ()
    {
        this.GetComponent<Renderer>().material = materialBlack;
	}
	
}
