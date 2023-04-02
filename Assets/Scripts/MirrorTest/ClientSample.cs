using Mirror;
using UnityEngine;

namespace MirrorTest
{
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
}
