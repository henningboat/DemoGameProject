using System;
using UnityEngine;

public class PlayerGraphics : MonoBehaviour
{
    SphereCollider _parentSphereCollider;
    Rigidbody _parentRigidbody;

    void Start()
    {
        _parentSphereCollider = GetComponentInParent<SphereCollider>();
        _parentRigidbody = GetComponentInParent<Rigidbody>();
    }

    void LateUpdate()
    {
        transform.position = _parentSphereCollider.transform.position + Vector3.down * _parentSphereCollider.radius;
        transform.rotation = Quaternion.LookRotation(new Vector3(_parentRigidbody.linearVelocity.x,0,_parentRigidbody.linearVelocity.z));
    }
}
