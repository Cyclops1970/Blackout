using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{
    public Joystick joystickMove; //see if player moving, so not to shoot when they stop
    public Joystick joystickRotate;

    public GameObject bullet;
    Vector3 aimAt, direction;
    float bulletPower = 1000f;
    float lastBulletTime;
    float bulletFrequency = 5;

    // Update is called once per frame
    void Update()
    {
        /*
        //assume moving and touch elsewhere to fire
        if ((Input.touchCount == 2) && (Input.GetTouch(1).phase == TouchPhase.Ended))
        {

            GameObject b = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            Rigidbody rb = b.GetComponentInChildren<Rigidbody>();

            aimAt = Camera.main.ScreenToWorldPoint((Vector3)(Input.GetTouch(1).position) + new Vector3(0, 0, 2)); //need to add a z amount to it otherwise it doesn't work
            direction = (aimAt - (Camera.main.transform.position));

            if (rb != null)
            {
                rb.AddForce(direction * bulletPower);// Vector3.forward * bulletPower);
            }
        }
        else if ((Input.touchCount == 1) && (Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            GameObject b = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            Rigidbody rb = b.GetComponentInChildren<Rigidbody>();

            aimAt = Camera.main.ScreenToWorldPoint((Vector3)(Input.GetTouch(0).position) + new Vector3(0, 0, 2)); //need to add a z amount to it otherwise it doesn't work
            direction = (aimAt - (Camera.main.transform.position));

            if (rb != null)
            {
                rb.AddForce(direction * bulletPower);// Vector3.forward * bulletPower);
            }

        }
        */
        //if moving, auto fire at frequency
        /*
        if((joystickMove.Horizontal!=0)||(joystickMove.Vertical!=0)||(joystickRotate.Horizontal!=0)||(joystickRotate.Vertical!=0))
        {
            if(Time.time-lastBulletTime>bulletFrequency)
            {
                GameObject b = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
                Rigidbody rb = b.GetComponentInChildren<Rigidbody>();

                //aimAt = new Vector3(Camera.main.transform.position.x)

                //direction = (aimAt - (Camera.main.transform.position));

                if (rb != null)
                {
                    //rb.AddForce(direction * bulletPower);// Vector3.forward * bulletPower);
                    direction = new Vector3(Camera.main.transform.localPosition.x, 1, 1);

                    rb.AddForce(direction * bulletPower);
                }

                lastBulletTime = Time.time;
            }
        }
        */
    }
}
