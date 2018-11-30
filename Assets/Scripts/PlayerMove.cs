using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;
    public Joystick joystickRotate;

    bool wallHit;

	void Update () 
	{
        if (wallHit == false)
        {
            //Move
            Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
            transform.Translate(moveVector * moveSpeed * Time.deltaTime);

            //Rotate
            Vector3 rotateVector = (transform.right * joystickRotate.Horizontal).normalized;
            transform.Rotate(transform.up, joystickRotate.Horizontal);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        wallHit = true;

        Vector3 direction = collision.transform.position - transform.position;
        if (Vector3.Dot(transform.forward, direction) > 0)
        {
            print("Back");
        }
        if (Vector3.Dot(transform.forward, direction) < 0)
        {
            print("Front");
        }
        if (Vector3.Dot(transform.forward, direction) == 0)
        {
            print("Side");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        wallHit = false;

        print("safe");
    }
}