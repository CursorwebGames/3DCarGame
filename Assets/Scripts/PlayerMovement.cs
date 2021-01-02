using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction.Normalize();

        rb.velocity += transform.TransformDirection(direction * speed * Time.fixedDeltaTime);
        rb.velocity.Normalize();

        if (Input.GetKey(KeyCode.X))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
