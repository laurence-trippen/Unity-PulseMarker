using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 40f;

    void Update()
    {
        transform.Rotate(Vector3.down, speed * Time.deltaTime);
    }
}
