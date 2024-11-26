using UnityEngine;

public class CameraTracking : MonoBehaviour {

    [SerializeField] float smoothTime;

    public Transform target;
    Vector3 relativePos = Vector3.zero;
    Vector3 smoothVel = Vector3.zero;

    void Start() {
        relativePos = transform.position;
    }

    void Update() {
    }

    private void FixedUpdate() {
        if (!target) {
            return;
        }
        transform.position = Vector3.SmoothDamp(transform.position, target.position + relativePos, ref smoothVel, smoothTime);
    }

}
