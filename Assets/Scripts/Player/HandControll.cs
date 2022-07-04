using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandControll : MonoBehaviour
{
    public ActionBasedController CameraController;
    public ActionBasedController RightHandController;
    public ActionBasedController LeftHandController;

    public Transform Physics;
    public Transform Modell;
    public Transform Head;
    public Transform Camera;

    public Transform RTarget;
    public Transform LTarget;

    private Vector3 _camPos;
    
    private Vector3 _rHandPos;
    private Vector3 _lHandPos;

    private Quaternion _rHandRot;
    private Quaternion _lHandRot;

    
    private void Update()
    {
        Input();

        // Modell.position = Physics.position;

        RTarget.position = Head.position + (_rHandPos - _camPos);
        LTarget.position = Head.position + (_lHandPos - _camPos);

        RTarget.rotation = _rHandRot;
        LTarget.rotation = _lHandRot;

        //Camera.position = Head.position;
    }

    private void Input()
    {        
        _camPos = CameraController.positionAction.action.ReadValue<Vector3>();

        _rHandPos = RightHandController.positionAction.action.ReadValue<Vector3>();
        _lHandPos = LeftHandController.positionAction.action.ReadValue<Vector3>();

        _rHandRot = RightHandController.rotationAction.action.ReadValue<Quaternion>();
        _lHandRot = LeftHandController.rotationAction.action.ReadValue<Quaternion>();
    }
}
