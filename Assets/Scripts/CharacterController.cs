using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterController : MonoBehaviour
{

    [SerializeField] float speed = 0f;
    [SerializeField] float rotationSpeed = 0f;

    InputController inputController = null;

    // Start is called before the first frame update
    void awake()
    {
        inputController = GetComponent<InputController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
        Vector2 input = inputController.MoveInput();
        transform.position += transform.forward * input.y * speed * Time.deltaTime;
        transform.Rotate(Vector3.up, input.x * rotationSpeed * Time.deltaTime);
    }
}
