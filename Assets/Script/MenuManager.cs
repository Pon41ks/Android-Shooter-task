using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;


public class MenuManager : MonoBehaviourPunCallbacks
{
    

    public TMP_InputField _createRoomField;
    public TMP_InputField _joinRoomField;

    

    public void _CreateRoom()
    {
        RoomOptions _roomOptions = new RoomOptions();
        _roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(_createRoomField.text, _roomOptions, TypedLobby.Default);
        Debug.Log("cool");
        
    }

    public void _JoinRandomRoom() 
    {
        PhotonNetwork.JoinRoom(_joinRoomField.text);
        Debug.Log("nice");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
        Debug.Log("asdasd");
    }
    
        
    






}

