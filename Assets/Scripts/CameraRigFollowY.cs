using UnityEngine;

[DefaultExecutionOrder(-1000)]
public class CameraRigFollowY : MonoBehaviour {
    public Transform target;

    void LateUpdate() {
        if (!target) return;

        var p = transform.position;
        p.y = target.position.y;
        transform.position = p;
    }
}
