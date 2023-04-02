using System;
using Mirror;
using UnityEngine;
using Unity.WebRTC;

public class WebRtcScript : NetworkBehaviour
{
    private void FixedUpdate()
    {
        if (isClient) {
            // Debug.Log("クライアントとして接続しました");
        }else if (isServer) {
            // Debug.Log("サーバーとして接続しましたあ");
        }
    }
}
