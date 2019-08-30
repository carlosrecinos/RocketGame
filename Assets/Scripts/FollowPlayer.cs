using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Vector3 offset;
    public Transform playerTransform;
    
    void Update() {
        transform.position = playerTransform.position + offset;
    }
}
