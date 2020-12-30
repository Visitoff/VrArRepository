using System.Collections;
using UnityEngine;
using Photon.Pun;
public class networkPlayerSpawn : MonoBehaviourPunCallbacks
{
    [SerializeField]
    Transform teleportKitchen;
    [SerializeField]
    Transform teleportTarget;
    [SerializeField]
    private GameObject spawnedPlayerPrefab;
    int a = 0;
    public override void OnJoinedRoom()
    {

        base.OnJoinedRoom();
        spawnedPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
        spawnedPlayerPrefab.tag = string.Format("player {0}", a);
        spawnedPlayerPrefab.GetComponent<ScenaroiForNet>().teleportKitchen = teleportKitchen;
        spawnedPlayerPrefab.GetComponent<ScenaroiForNet>().teleportTarget = teleportTarget;
        Camera.main.gameObject.transform.SetParent(spawnedPlayerPrefab.transform);
        a++;
    }
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedPlayerPrefab);
    }
}
