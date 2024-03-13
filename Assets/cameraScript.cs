using UnityEngine;

public class CarCameraFollow : MonoBehaviour
{
    public Transform carTransform; // Reference to the car's Transform component

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - carTransform.position;
    }

    private void Update()
    {
        // Update the camera's position based on the car's position and rotation
        transform.position = carTransform.position + offset;
        transform.rotation = carTransform.rotation;
    }
}
