using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNube : MonoBehaviour
{   
    public float velocidadUp;
    public float velocidadRight;
    public float velocidadLeft;
    public float velocidadDown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.up * Time.deltaTime * velocidadUp);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * Time.deltaTime * velocidadRight);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * Time.deltaTime * velocidadLeft);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.down * Time.deltaTime * velocidadDown);
        }
    }

    private void OnTriggerStay(Collider other){
        if(other.tag == "Cielo_OccidOriente")
        {
            velocidadRight = 0;
            velocidadLeft = 0;
        }

        if(other.tag == "Cielo_NorteSur")
        {
            velocidadUp = 0;
            velocidadDown = 0;
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player")
        {
            velocidadRight = 5;
            velocidadLeft = 5;
            velocidadUp = 5;
            velocidadDown = 5;
        }
    }

    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.tag == "Player")
        {
            velocidadRight = 0;
            velocidadLeft = 0;
            velocidadUp = 0;
            velocidadDown = 0;
        }
    }
}