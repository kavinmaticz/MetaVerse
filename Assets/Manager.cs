using UnityEngine;
using Photon.Pun;
public class Manager : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        print("Connecting");
    }

    public override void OnConnectedToMaster()
    {
        //base.OnConnectedToMaster();
        print("Connected");
        PhotonNetwork.JoinLobby();

    }

    public override void OnJoinedLobby()
    {
        //base.OnJoinedLobby();
        print("Joined");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
