using System;
using Mirror;

public class CustomNetworkManager : NetworkManager
{
//====================
// ホスト・クライアント・サーバーの開始・停止
//====================
    // ホストの開始時に呼ばれる
    public override void OnStartHost() 
    {
        base.OnStartHost();
        print("OnStartHost");
    }

    // クライアントの開始時に呼ばれる
    public override void OnStartClient() 
    {
        base.OnStartClient();
        print("OnStartClient");
    }

    // サーバーの開始時に呼ばれる
    public override void OnStartServer() 
    {
        base.OnStartServer();
        print("OnStartServer");
    } 

    // ホストの停止時に呼ばれる
    public override void OnStopHost() 
    {
        base.OnStopHost();
        print("OnStopHost");
    }

    // クライアントの停止時に呼ばれる
    public override void OnStopClient() 
    {
        base.OnStopClient();
        print("OnStopClient");
    }

    // サーバーの停止時に呼ばれる
    public override void OnStopServer() 
    {
        base.OnStopServer();
        print("OnStopServer");
    }

//====================
// クライアント
//====================
    // クライアントのエラー時に呼ばれる
    public override void OnClientError(Exception exception)
    {
        base.OnClientError(exception);
        print("OnClientError : "+exception);
    }

    // クライアントのシーン読み込み完了時に呼ばれる
    public override void OnClientChangeScene(string sceneName, SceneOperation sceneOperation, bool customHandlin) 
    {
        base.OnClientChangeScene(sceneName, sceneOperation, customHandlin);
        print("OnClientChangeScene : "+sceneName);
    }

//====================
// サーバー
//====================
    // サーバーのシーン読み込み完了時に呼ばれる
    public override void OnServerChangeScene(string sceneName) 
    {
        base.OnServerChangeScene(sceneName);
        print("OnServerChangeScene : "+sceneName);
    }
}