using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputController))]
public class CameraController : MonoBehaviour
{
    [SerializeField] float mouseSensitivy = 0f;
    [SerializeField] Transform cameraAnchor = null;

    InputController inputController = null;

    void Awake()
    {
        inputController = GetComponent<InputController>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseCamera();
    }

    void MouseCamera()
    {
        Vector2 input = inputController.MouseInput();
        transform.Rotate(Vector3.up, input.x * mouseSensitivy * Time.deltaTime);
        Vector3 angle = cameraAnchor.localEulerAngles;
        angle.x -= input.y * mouseSensitivy * Time.deltaTime;

        cameraAnchor.localEulerAngles = angle;
    }
}
