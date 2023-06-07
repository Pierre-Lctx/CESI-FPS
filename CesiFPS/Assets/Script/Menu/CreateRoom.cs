using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Realtime;

public class CreateRoom : MonoBehaviourPunCallbacks
{

    [SerializeField]
    private TMP_Text _roomName;

    public RoomsCanvases _roomCanvases;

    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomCanvases = canvases;
    }

    public void OnClick_CreateRoom()
    {
        if (!PhotonNetwork.IsConnected) 
            return;

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 20;
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();

        print("Created room successfully");

        _roomCanvases.CreateOrJoinRoomCanvas.Hide();
        _roomCanvases.CurrentRoomCanvas.Show();
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
        print("Room creation failed : " + message);
    }
}
