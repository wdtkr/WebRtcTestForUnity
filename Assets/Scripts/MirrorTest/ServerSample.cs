using Mirror;
using UnityEngine;


namespace MirrorTest
{
    public class SeverSample : NetworkBehaviour
    {
        private void Update()
        {
            var sendData = new SendData()
            {
                value = Random.Range(0,10)
            };
            
            NetworkServer.SendToAll(sendData);
        }
    }
}

