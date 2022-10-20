using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    float r;
    float e;

    void Start()
    {
        r = 1;
        e = 1;
    }
    void Update()
    {
        r += Time.deltaTime * 90f;
        e += Time.deltaTime * 100f;
        transform.rotation = Quaternion.Euler(transform.rotation.x, r, transform.rotation.z);
        transform.rotation = Quaternion.Euler(e, transform.rotation.y, transform.rotation.z);
    }
}