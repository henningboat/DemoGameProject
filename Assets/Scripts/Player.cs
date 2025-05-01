using System;
using UnityEngine;

public class Player : Singleton<Player>
{
    Rigidbody _rigidbody;
    [SerializeField]float _moveSpeed=3;
    

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var movementForce = new Vector3(Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical")) * _moveSpeed;
        _rigidbody.AddForce(movementForce, ForceMode.Acceleration);
    }
}