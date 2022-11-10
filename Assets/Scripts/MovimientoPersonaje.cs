using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRot = 200.0f;
    private Animator anim;
    public float x, y;

    public Rigidbody rb;
    public float fuerzaSalto = 5f;
    public bool puedoSaltar;
    
    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoG = 6f;

    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);
        }

        if (avanzoSolo)
        {
            rb.velocity = transform.forward*impulsoG;
        }
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (puedoSaltar)
        {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    anim.SetBool("IsJumping", true);
                    rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
                }
                anim.SetBool("Suelo?", true);
        }
        else
        {
            EstoyCayendo();
        }
    }

    public void EstoyCayendo()
    {
        anim.SetBool("Suelo?", false);
        anim.SetBool("IsJumping", false);
    }

    public void DejeDeGolpear()
    {
        estoyAtacando = false;
    }

    public void AnanzoSolo()
    {
        avanzoSolo = true;
    }

    public void DejoDeAvanzar()
    {
        avanzoSolo = false;
    }

}
