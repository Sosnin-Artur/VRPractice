using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLimb : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private ConfigurableJoint _configurableJoint;

    private Quaternion _initialRotation;

    private void Awake()
    {
        _initialRotation = _target.localRotation;
    }

    private void FixedUpdate()
    {
        _configurableJoint.targetRotation = CopyLimb();
    }

    private Quaternion CopyLimb()
    {
        return Quaternion.Inverse(_target.localRotation) * _initialRotation;
    }
}
