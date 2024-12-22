using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class XRRigStateManager : MonoBehaviour {

    [SerializeField] GameObject rigOrigin;
    [SerializeField] GameObject rigHead;
    [SerializeField] GameObject rigHandL;
    [SerializeField] GameObject rigHandR;

    public bool rigEnabledOnStart;

    bool _rigEnabled;
    public bool rigEnabled {
        get => _rigEnabled;
        set {
            _rigEnabled = value;
            if (value) {
                setRigEnabled(true);
            } else {
                setRigEnabled(false);
            }
        }
    }

    void setRigEnabled(bool v) {
        rigOrigin.GetComponent<XROrigin>().enabled = v;
        rigOrigin.GetComponent<InputActionManager>().enabled = v;
        rigHead.GetComponent<Camera>().enabled = v;
        rigHead.GetComponent<AudioListener>().enabled = v;
        rigHead.GetComponent<TrackedPoseDriver>().enabled = v;
        rigHandL.GetComponent<ActionBasedController>().enabled = v;
        rigHandL.GetComponent<XRRayInteractor>().enabled = v;
        rigHandR.GetComponent<ActionBasedController>().enabled = v;
        rigHandR.GetComponent<XRRayInteractor>().enabled = v;
    }

    void Start() {
        rigEnabled = rigEnabledOnStart;
    }

    void Update() {
    }

}
