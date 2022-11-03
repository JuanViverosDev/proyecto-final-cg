using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformJump : MonoBehaviour
{
    public Rigidbody rb;
    public float fuerzaSalto;

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Salto en Hongo");
        if (other.tag == "ImpulsoSalto")
        {
            Debug.Log(other.name);
            rb.AddForce(new Vector3(0,fuerzaSalto,0),ForceMode.Impulse);
        }
    }

        private void OnTriggerExit(Collider other)
    {
        Debug.Log("Objeto Salto");
        if (other.tag == "ImpulsoSalto")
        {
            Debug.Log(other.name);
        }
    }

}
