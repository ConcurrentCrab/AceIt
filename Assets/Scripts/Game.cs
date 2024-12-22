using System;
using System.Threading.Tasks;
using UnityEngine;

public static class GameGlobal {

    public static Game game;

}

public class Game : MonoBehaviour {

    [SerializeField] GameObject player;

    public GameObject Player => player;

    public void AssignPlayer(GameObject p) {
        player = p;
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
