using UnityEngine;
using Photon.Pun;

public class PhotonTransform : MonoBehaviour, IPunObservable {

    void Start() {
    }

    void Update() {
    }

    void IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
        Vector3 pos = transform.localPosition;
        Quaternion rot = transform.localRotation;
        Vector3 scl = transform.localScale;
        stream.Serialize(ref pos);
        stream.Serialize(ref rot);
        stream.Serialize(ref scl);
        if (!stream.IsWriting) {
            transform.localPosition = pos;
            transform.localRotation = rot;
            transform.localScale = scl;
        }
    }

}
