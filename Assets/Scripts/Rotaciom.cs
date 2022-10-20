using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaciom : MonoBehaviour
{
    float r;
    
    // Start is called before the first frame update
    void Start()
    {
        r = 1;
    }

    // Update is called once per frame
    void Update()
    {
        r += Time.deltaTime * 35f;

        
            transform.rotation = Quaternion.Euler(transform.rotation.x, r, transform.rotation.z);

    }
}
