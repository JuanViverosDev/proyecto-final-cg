using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoralTrigger : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidadRio;

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Rio_NorteSurPositivo")
        {
            rb.transform.Translate(new Vector3(velocidadRio,0,0));
        }
        
        if (other.tag == "Rio_OccidOrientePositivo")
        {
            rb.transform.Translate(new Vector3(0,0,velocidadRio));
        }

        if (other.tag == "Rio_NorteSurNegativo")
        {
            rb.transform.Translate(new Vector3(-velocidadRio,0,0));
        }
        
        if (other.tag == "Rio_OccidOrienteNegativo")
        {
            rb.transform.Translate(new Vector3(0,0,-velocidadRio));
        }
    }

}
