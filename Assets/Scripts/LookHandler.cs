using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookHandler : MonoBehaviour
{
    
    public float sensitivity =100.0f;
    // Update is called once per frame
    float xRotation = 0f;

    public Transform playerBody;
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*sensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*sensitivity*Time.deltaTime;
        
        xRotation -=mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up*mouseX);

    }
}
