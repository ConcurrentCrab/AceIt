using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;
using Photon.Realtime;

public class PhotonGame : MonoBehaviourPunCallbacks {

    [SerializeField] GameObject playerPrefab;

    void Start() {
        PhotonNetwork.ConnectUsingSettings();
    }

    void Update() {
    }

    public override void OnConnectedToMaster() {
        RoomOptions roomOptions = new() {
            IsOpen = true,
            MaxPlayers = 4,
        };
        PhotonNetwork.JoinOrCreateRoom("TEST", roomOptions, TypedLobby.Default);
    }

    public override void OnCreatedRoom() {
    }

    public override void OnJoinedRoom() {
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
        player.GetComponent<PlayerInput>().enabled = true;
        GameGlobal.game.AssignPlayer(player);
    }

    public override void OnMasterClientSwitched(Photon.Realtime.Player newMasterClient) {
    }

}
