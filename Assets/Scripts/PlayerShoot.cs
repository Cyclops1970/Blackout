using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{

    public GameObject bullet;

    float bulletPower = 2000f;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
	{	
        if(Input.GetMouseButtonUp(0)==true)
        {
            GameObject b = Instantiate(bullet, gameObject.transform.localPosition + Vector3.forward*2, Quaternion.identity);
            Rigidbody rb = b.GetComponentInChildren<Rigidbody>();

            if (rb != null)
            {
                rb.AddForce(Vector3.forward * bulletPower);
            }
            else
            {
                print("something went wrong");
            }
        }
	}
}
