using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public Transform player;
    public Rigidbody rb;

    void FixedUpdate()
    {
        // rotation
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed;

        Quaternion rotation = Quaternion.AngleAxis(horizontal, Vector3.up);
        player.localRotation *= rotation;


        // movement
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(0, 0, vertical);
        rb.velocity += player.TransformDirection(direction * speed * Time.fixedDeltaTime);
        rb.velocity.Normalize();


        // brakes
        if (Input.GetKey(KeyCode.X))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        // reset
        if (Input.GetKey(KeyCode.R))
        {
            player.localRotation = Quaternion.identity;
        }
    }
}
