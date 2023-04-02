using System.Collections;
using System.Collections.Generic;
using Mirror;
using MirrorTest;
using UnityEngine;

public class ClientSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NetworkClient.RegisterHandler<SendData>(ReceivedInfo);
    }

    private void ReceivedInfo(SendData receivedData)
    {
        Debug.Log(JsonUtility.ToJson(receivedData));
    }
}
