using UnityEngine;

public class camera : MonoBehaviour
{
    [Header("folow Settings")]
    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 offset = new Vector3(0, 0, -10);
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        if (target == null){ Debug.LogWarning("camera target is not assigned!");
        return;
        
    }
    Vector3 targetPosition = target.position + offset;
    targetPosition.z = transform.position.z;

    transform.position = Vector3.SmoothDamp (
        transform.position,
        targetPosition,
        ref velocity,
        smoothTime
    );
       
    }

    
}