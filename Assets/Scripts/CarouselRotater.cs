using UnityEngine;

public class CarouselRotater : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = Quaternion.AngleAxis(1, Vector3.up);
        transform.rotation *= rotation;
    }
}
