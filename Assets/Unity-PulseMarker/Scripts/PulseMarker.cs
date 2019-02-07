using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseMarker : MonoBehaviour
{
    public float rotationXOffest;

    private void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(transform.rotation.x + rotationXOffest, 0, 0);
    }
}