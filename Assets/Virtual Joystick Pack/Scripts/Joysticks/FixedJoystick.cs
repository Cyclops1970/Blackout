﻿using UnityEngine;
using UnityEngine.EventSystems;

public class FixedJoystick : Joystick
{
    //what the joystick controls
    public GameObject player;

    [HideInInspector]
    //public bool usingJoystick;

    [Header("Fixed Joystick")]

    Vector2 joystickPosition = Vector2.zero;
    private Camera cam = new Camera();

    void Start()
    {
        joystickPosition = RectTransformUtility.WorldToScreenPoint(cam, background.position);
    }

    public override void OnDrag(PointerEventData eventData)
    {

        Vector2 direction = eventData.position - joystickPosition;
        inputVector = (direction.magnitude > background.sizeDelta.x / 2f) ? direction.normalized : direction / (background.sizeDelta.x / 2f);
        handle.anchoredPosition = (inputVector * background.sizeDelta.x / 2f) * handleLimit;
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        //my code
        //player.transform.rotation = Quaternion.identity;
        //player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        //my code

        OnDrag(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        //my code
        //player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        //my code

        inputVector = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;

    }
}