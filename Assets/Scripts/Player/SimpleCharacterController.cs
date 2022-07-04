using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class SimpleCharacterController : MonoBehaviour
{
    public ActionBasedController CameraController;
    public InputActionReference MovementAction;

    public Transform Body;
    
    public float Speed;

    private Vector2 _direction;
    private Quaternion _headRot;

    private void Update()
    {
        _headRot = Quaternion.Euler(
            0, 
            CameraController.rotationAction.action.ReadValue<Quaternion>().eulerAngles.y, 
            0);

        _direction = MovementAction.action.ReadValue<Vector2>();

        Body.GetComponent<Rigidbody>().AddForce(
            (_headRot * new Vector3(_direction.x, 0, _direction.y)) * Speed);
    }
}
