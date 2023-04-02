using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
namespace MirrorTest
{
    public struct SendData : NetworkMessage
    {
        public int value;
    }
}

