using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour
{
    public GameObject txt;
    void Start()
    {
        StartCoroutine(Test());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Test()
    {
        yield return new WaitForSeconds(10);
        txt.SetActive(false);
    }

}