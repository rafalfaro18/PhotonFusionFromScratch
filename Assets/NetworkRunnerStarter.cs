using Fusion;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class NetworkRunnerStarter : MonoBehaviour
{
    NetworkRunner _nr;
    StartGameArgs gameArgs;

    [Inject]
    public void Init(NetworkRunner nr) {
        _nr = nr;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameArgs.GameMode = GameMode.Shared;
        StartNetworkRunner();
    }

    private void StartNetworkRunner()
    {
        _nr.StartGame(gameArgs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
