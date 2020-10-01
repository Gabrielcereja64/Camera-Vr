using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float mouseSensi = 100f;
    
    public Transform negãoplayer;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
      float mouseX = Input.GetAxis("Mouse X") * mouseSensi * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y") * mouseSensi * Time.deltaTime;
        
      negãoplayer.Rotate (Vector3.up * mouseX);
      
      xRotation -= mouseY;
      xRotation = Mathf.Clamp(xRotation, -90f, 90f);
      
      transform.localRotation = Quaternion.Euler (xRotation, 0f, 0f);
    }
}
