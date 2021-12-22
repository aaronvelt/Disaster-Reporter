using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity = 100f;
    private float _angleX;
    private float _angleY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        _angleX -= mouseY;
        _angleX = Mathf.Clamp(_angleX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_angleX, 0f, 0f);
        playerBody.transform.Rotate(Vector3.up * mouseX);
    }
}
