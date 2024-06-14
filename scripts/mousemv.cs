using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemv : MonoBehaviour

{
    float sensibilidade = 5.0f;
    float mouseX = -100f;
    float mouseY = 0f;


    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensibilidade;
        mouseY -= Input.GetAxis("Mouse Y") * sensibilidade;

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}