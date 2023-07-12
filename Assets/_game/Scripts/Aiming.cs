using System;
using UnityEngine;

public class Aiming : MonoBehaviour
{

    public float horizontalRotation = 0;
    public float verticalRotation = 0;
    public float rotationSpeed;
    public float maxHorizontal;
    public float minHorizontal;
    public float maxVertical;
    public float minVertical;
    void Rotate()
    {
        float horizontalMouse = Input.GetAxis("Horizontal");
        float verticalMouse = Input.GetAxis("Vertical");
        horizontalRotation += horizontalMouse * Time.deltaTime * rotationSpeed;
        horizontalRotation = Math.Clamp(horizontalRotation, minHorizontal, maxHorizontal);
        verticalRotation += verticalMouse * Time.deltaTime * rotationSpeed;
        verticalRotation = Math.Clamp(verticalRotation, minVertical, maxVertical);
        transform.eulerAngles = new Vector3(0, horizontalRotation, verticalRotation);
    }

    private void Update()
    {
        Rotate();
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.enabled = false;

    }


}
