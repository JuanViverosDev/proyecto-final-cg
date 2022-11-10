using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterController : MonoBehaviour
{
    public float velocidadM = 5.0f;
    public float velocidadR = 200.0f;
    private Animator a;
    public float x, y;
    public Rigidbody rb;
    public float fSalto = 8f;
    public bool saltar;
    public GameObject otherP;

    void Start()
    {
        saltar = false;
        a = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadR, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadM);
        otherP.transform.rotation = transform.rotation;
        otherP.transform.position = transform.position;
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        a.SetFloat("velX", x);
        a.SetFloat("velY", y);

        if (saltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                a.SetBool("salto", true);
                rb.AddForce(new Vector3(0, fSalto, 0), ForceMode.Impulse);
            }
            a.SetBool("suelo", true);
        }
        else
        {
            caer();
        }

    }
    public void caer()
    {
        // a.SetBool("suelo", false);x
        // a.SetBool("isJumping", false);
    }
}