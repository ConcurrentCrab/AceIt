using UnityEngine;
using Photon.Pun;

public class PhotonTransform : MonoBehaviour, IPunObservable {

    void Start() {
    }

    void Update() {
    }

    void IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
        Vector3 pos = new ();
        Quaternion rot = new ();
        Vector3 scl = new ();
        if (stream.IsWriting) {
            pos = transform.localPosition;
            rot = transform.localRotation;
            scl = transform.localScale;
        }
        stream.Serialize(ref pos);
        stream.Serialize(ref rot);
        stream.Serialize(ref scl);
        if (stream.IsReading) {
            transform.localPosition = pos;
            transform.localRotation = rot;
            transform.localScale = scl;
        }
    }

}
