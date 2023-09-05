using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float sensitivityH;
    public float sensitivityW;

    private float _yaw = 0.0f;
    private float _pitch = 0.0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        _yaw += sensitivityH * Input.GetAxis("Mouse X");
        _pitch -= sensitivityW * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(_pitch, _yaw, 0.0f);
    }
}
