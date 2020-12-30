using Photon.Pun.Demo.PunBasics;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScenaroiForNet : MonoBehaviourPunCallbacks
{

    public Transform teleportKitchen;

    public Transform teleportTarget;
    int ScenarioMode = 1;

    void Start()
    {
        CameraWork _cameraWork = gameObject.GetComponent<CameraWork>();

        if (_cameraWork != null)
        {
            if (photonView.IsMine)
            {
                _cameraWork.OnStartFollowing();
            }
        }
        else
        {
            Debug.LogError("<Color=Red><b>Missing</b></Color> CameraWork Component on player Prefab.", this);
        }

        gameObject.transform.position = teleportTarget.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && tag == "player 0")
            gameObject.transform.position = teleportKitchen.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha2) && tag == "player 0")
            gameObject.transform.position = teleportTarget.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha3) && tag == "player 0")
            Debug.Log(tag);

        if (Input.GetKeyDown(KeyCode.Alpha1) && tag == "player 1")
            gameObject.transform.position = teleportKitchen.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha2) && tag == "player 1")
            gameObject.transform.position = teleportTarget.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha3) && tag == "player 1")
            Debug.Log(tag);


    }

}
