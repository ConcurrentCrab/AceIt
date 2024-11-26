using UnityEngine;

public class Player : MonoBehaviour {

    enum StateEnum {
        Normal,
    }

    PlayerMove move;
    PlayerAim aim;

    StateEnum state = StateEnum.Normal;

    void Start() {
        move = GetComponent<PlayerMove>();
        aim = GetComponent<PlayerAim>();
    }

    void Update() {
    }

    private void FixedUpdate() {
        switch (state) {
        case StateEnum.Normal:
            move.processMove();
            aim.processAim();
            break;
        }
    }

}
