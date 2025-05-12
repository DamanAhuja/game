using UnityEngine;
public class CarController : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Move the car forward
        rb.velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a wall
        if (collision.gameObject.CompareTag("GameController"))
        {
            // Rotate the car by 180 degrees
            transform.Rotate(Vector3.up, 180f);

            // Reverse the speed to move in the opposite direction
            rb.velocity = -rb.velocity;
        }
    }
}
