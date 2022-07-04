using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.InputSystem;

[System.Serializable]
public class MapTransform
{
    public Transform vrTarget;
    public Transform IKTarget;
    public Vector3 trackingPositionOffset;
    public Quaternion trackingRotationOffset;

    public void Setup()
    {
        vrTarget.transform.position = IKTarget.transform.position;
        vrTarget.transform.rotation = IKTarget.transform.rotation;
                
        trackingRotationOffset = IKTarget.transform.localRotation;        
    }

    public void MapVRAvatar()
    {
        IKTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        IKTarget.rotation = vrTarget.rotation * trackingRotationOffset;
    }
}
