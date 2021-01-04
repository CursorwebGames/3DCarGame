using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    public Transform lookAt;
    public Transform camPos;

    public float camY;


    void Update()
    {
        transform.position = new Vector3(camPos.position.x, camY, camPos.position.z);
        transform.LookAt(lookAt);
    }
}
