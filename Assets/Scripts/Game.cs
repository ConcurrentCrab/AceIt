using System;
using System.Threading.Tasks;
using UnityEngine;

public static class GameGlobal {

    public static Game game;

}

public class Game : MonoBehaviour {

    [SerializeField] GameObject player;
    [SerializeField] Camera cam;

    public GameObject Player => player;

    public Camera Cam => cam;

    public void AssignPlayer(GameObject p) {
        player = p;
        cam.gameObject.GetComponent<CameraTracking>().target = player.transform;
    }

    private void Awake() {
        GameGlobal.game = this;
    }

    void Start() {
    }

    void Update() {
    }

    void FixedUpdate() {
    }

}
