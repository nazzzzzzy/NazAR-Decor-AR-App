using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public Transform earth;

    void Update()
    {
        transform.RotateAround(earth.position, Vector3.up, 50 * Time.deltaTime);
    }
}