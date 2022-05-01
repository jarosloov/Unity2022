using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Pendulum : MonoBehaviour
{
    [SerializeField] public float angle;
    [SerializeField] public float d;
    [SerializeField] public float speed;

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        transform.position = new Vector3(d * Mathf.Sin(angle), -d * Mathf.Cos(angle), 0);
        var hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;
        if (hinge != null) hinge.anchor = new Vector3(-d * Mathf.Sin(angle), d * Mathf.Cos(angle), 0);

        rb.AddForce(-speed * Mathf.Cos(angle), -speed * Mathf.Sin(angle), 0, ForceMode.VelocityChange);
    }

}
