using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystickMove;
    public Joystick joystickRotate;
    float keyboardSpeed = 1;

    void Update () 
	{
        //Reset scene shortcut **** remove when done ****
        if(Input.GetKeyUp(KeyCode.F12))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }

        //Currently setup to work with the movejoystick only....commented ones will run off one joysticks
        //Move
        Vector3 moveVector = (Vector3.right * joystickMove.Horizontal + Vector3.forward * joystickMove.Vertical).normalized;
        //Vector3 moveVector = (Vector3.forward * joystickMove.Vertical).normalized;
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);

        //Rotate
        Vector3 rotateVector = (Vector3.right * joystickRotate.Horizontal).normalized;
        //Vector3 rotateVector = (Vector3.right * joystickMove.Horizontal).normalized;
        transform.Rotate(transform.up, joystickRotate.Horizontal*2);
        //transform.Rotate(transform.up, joystickMove.Horizontal * 2);

    }
}