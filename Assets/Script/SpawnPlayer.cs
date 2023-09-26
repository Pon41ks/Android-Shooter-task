using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player1;
    [SerializeField] private Transform spawn;


    void Start()
    {
        PhotonNetwork.Instantiate(Player1.name, spawn.position, Quaternion.identity);
    }

}
