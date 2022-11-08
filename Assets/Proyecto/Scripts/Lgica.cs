using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lgica : MonoBehaviour
{
    public float velM = 5f, velR = 250f, salto = 8f;
    private Animator anim;
    public Rigidbody rb;
    public bool canJump;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velR, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velM);
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");



        if (Input.GetKey(KeyCode.LeftShift))
        {
            velM = 10f;
            anim.SetBool("Run", true);
        }
        else
        {
            velM = 5f;
            anim.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.B))
        {
            anim.SetBool("Dance", true);
        }
        else
        {
            anim.SetBool("Dance", false);
        }


        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (canJump){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Jump", true);
                rb.AddForce(new Vector3(0, salto, 0), ForceMode.Impulse);
            }
            anim.SetBool("Floor", true);
        }
        else
        {
            anim.SetBool("Floor", false);
            anim.SetBool("Jump", false);
        }

    }
}
