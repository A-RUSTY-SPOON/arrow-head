using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void fixedupdate()
    {
        Vector3 desierdPostition = target.position + offset;
        Vector3 smoothPostition = Vector3.Lerp(transform.position, desierdPostition, smoothSpeed);
        transform.position = smoothPostition;
    }
}
