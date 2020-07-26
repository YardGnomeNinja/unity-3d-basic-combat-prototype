using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Vector3 cameraOffset;
    public float smoothSpeed = 12f;
    public Transform targetTransform;
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        Vector3 targetPosition = targetTransform.position + cameraOffset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed * Time.deltaTime);
        
        transform.position = smoothedPosition;
    }
}
