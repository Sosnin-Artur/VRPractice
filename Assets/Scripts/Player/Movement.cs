using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Movement : MonoBehaviour
{
    public ActionBasedController CameraController;
    public Transform Model;
    public Transform Body;

    private Quaternion _camRot;

    private void Update()
    {
        _camRot = CameraController.rotationAction.action.ReadValue<Quaternion>();

        // Model.rotation = Quaternion.Euler(0, _camRot.eulerAngles.y, 0);
        Body.rotation = Quaternion.Euler(0, _camRot.eulerAngles.y, 0);
    }
}
