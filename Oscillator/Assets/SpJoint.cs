using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpJoint : MonoBehaviour
{
    private Vector3 _position;
    private void Awake()
    {
        _position = new Vector3(0, _position.y + 1, 0);
    }

    private void OnDrawGizmos()
    {
        var pos = transform.position;
        Gizmos.DrawLine(pos, _position);
    }
}