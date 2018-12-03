using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSticky : MonoBehaviour {

    public Material materialBlack;

    // Use this for initialization
    void Start () {
        this.GetComponent<Renderer>().material = materialBlack;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
