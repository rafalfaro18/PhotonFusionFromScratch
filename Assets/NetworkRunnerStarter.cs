using Fusion;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class NetworkRunnerStarter : MonoBehaviour
{
    NetworkRunner _nr;

    [Inject]
    public void Init(NetworkRunner nr) {
        _nr = nr;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartNetworkRunner(GameMode.Shared);
    }

    private void StartNetworkRunner(GameMode mode)
    {
        _nr.StartGame(new StartGameArgs()
        {
            GameMode = mode,
            SessionName = "TestRoom",
            Scene = SceneManager.GetActiveScene().buildIndex,
            SceneManager = gameObject.AddComponent<NetworkSceneManagerDefault>()
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
