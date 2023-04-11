using Fusion;
using QFSW.QC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Zenject;

public class VideoPlayerControl : NetworkBehaviour
{
    NetworkRunner _nr;
    VideoPlayer _player;

    [Inject]
    public void Init(NetworkRunner nr)
    {
        _nr = nr;
    }

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Command]
    public void PlayVideo() {
        RPC_PlayVideo();
    }

    [Rpc]
    public void RPC_PlayVideo() {
        _player.Play();
    }
}
