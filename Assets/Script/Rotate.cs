using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 1f; // Adjust the speed as necessary

    // Update is called once per frame
    void Update()
    {
        // Rotate the Ferris wheel around its up axis at the desired speed
        transform.Rotate(Vector3.forward, Time.deltaTime * 10);
    }
}