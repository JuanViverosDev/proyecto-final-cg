using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarAround : MonoBehaviour
{
    public GameObject sol;
    public float v;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
            transform.RotateAround(sol.transform.position, Vector3.up, v * Time.deltaTime);
    }
}
