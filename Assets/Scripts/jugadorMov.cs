using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorMov : MonoBehaviour
{
    public float fore = 150;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h= Input.GetAxis("Horizontal");
        float w= Input.GetAxis("Vertical");

        Vector3 v= new Vector3(h, 0.5f, w);

        rb.AddForce(v*fore*Time.deltaTime);
    }
}
