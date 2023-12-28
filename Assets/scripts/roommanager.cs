using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class roommanager : MonoBehaviourPunCallbacks
{

    public GameObject player;
    [Space]
    public Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("connecting...");
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public override void OnConnectedToMaster() 
   {
    base.OnConnectedToMaster();
    Debug.Log("connected to server!");
    PhotonNetwork.JoinLobby();


   }
   public override void OnJoinedLobby()
   {
    base.OnJoinedLobby();
    PhotonNetwork.JoinOrCreateRoom("Test",null,null);
    Debug.Log("We are connected and in a room now!");
    Invoke("PhotonInit",10);

   }
   void PhotonInit(){
    GameObject _player = PhotonNetwork.Instantiate (player.name,spawnpoint.position,Quaternion.identity);
   }
 
}