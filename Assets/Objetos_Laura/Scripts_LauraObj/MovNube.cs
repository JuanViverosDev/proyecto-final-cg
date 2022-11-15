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


    private void OnTriggerStay(Collider other){
        if (Input.GetKey(KeyCode.S) && other.CompareTag("Player")) 
        {
            Debug.Log("si");
            transform.Translate(Vector3.up * Time.deltaTime * velocidadUp);
        }
        if (Input.GetKey(KeyCode.A) && other.CompareTag("Player"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * velocidadRight);
        }
        if (Input.GetKey(KeyCode.D) && other.CompareTag("Player"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * velocidadLeft);
        }
        if (Input.GetKey(KeyCode.W) && other.CompareTag("Player"))
        {
            transform.Translate(Vector3.down * Time.deltaTime * velocidadDown);
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