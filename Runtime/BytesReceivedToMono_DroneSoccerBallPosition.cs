using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BytesReceivedToMono_DroneSoccerBallPosition : AbstractBytesReceivedToMono
{

    private void Reset()
    {
        m_valideId = new byte[] { 8 };
    }

    private void Awake()
    {
        m_valideId = new byte[] { 8 };
    }

    protected override void PushInParserImplement(byte id, byte[] bytes)
    {
        if (id == 11)
        {
        
        }
    }
}