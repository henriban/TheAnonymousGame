using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameSpawner : NetworkBehaviour {

    public GameObject gamePrefab;
    private GameObject initedObject;

    public GameObject GetInitedBoard()
    {
        return initedObject;
    }

    public override void OnStartServer()
    {
        initedObject = (GameObject)Instantiate(gamePrefab);
        NetworkServer.Spawn(initedObject);
    }
}
