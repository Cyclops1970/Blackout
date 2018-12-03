using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stickyBlock")
        {
            gameObject.GetComponent<Rigidbody>().drag = 25;
        }
        else
        {
            print("Light hit " + collision.gameObject.name);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "stickyBlock")
        {
            //gameObject.GetComponent<Rigidbody>().mass = 0.01f;
            gameObject.GetComponent<Rigidbody>().drag = 25;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().drag = 0;
    }
}
