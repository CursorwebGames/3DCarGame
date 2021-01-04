using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    public Transform lookAt;
    public Transform camPos;

    public float camY;


    private void Update()
    {
        float posY = Mathf.Clamp(camY + camPos.position.y, camY, float.MaxValue);
        transform.position = new Vector3(camPos.position.x, posY, camPos.position.z);
        transform.LookAt(lookAt);
    }
}
