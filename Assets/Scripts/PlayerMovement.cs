using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public Transform player;
    public Rigidbody rb;

    public float maxHorizDeg = 45f;
    public float resetSpeed = 50f;


    void FixedUpdate()
    {
        // movement
        // local vector
        Vector3 localUp = player.up;
        Quaternion vertAng = Quaternion.FromToRotation(localUp, Vector3.up) * rb.rotation;
        float vertAngDiff = Quaternion.Angle(rb.rotation, vertAng);
        if (vertAngDiff < maxHorizDeg)
        {
            // move only if it is upright
            float vertical = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(0, 0, vertical);

            float playerSpeed = speed;
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) playerSpeed *= 2;

            rb.velocity += player.TransformDirection(direction * playerSpeed * Time.fixedDeltaTime);
            rb.velocity.Normalize();
        }


        // rotation
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed;

        Quaternion rotation = Quaternion.AngleAxis(horizontal, Vector3.up);
        player.localRotation *= rotation;


        // brakes
        if (Input.GetKey(KeyCode.X))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        // reset
        if (Input.GetKey(KeyCode.R))
        {
            player.localRotation = Quaternion.identity * Quaternion.AngleAxis(player.localRotation.y, Vector3.up);
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
