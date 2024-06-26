using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BytesReceivedToMono_DroneSoccerBallGoalsField : AbstractBytesReceivedToMono
{

    private void Reset()
    {
        m_valideId = new byte[] { 14 };
    }

    private void Awake()
    {
        m_valideId = new byte[] { 14 };
    }

    protected override void PushInParserImplement(byte id, byte[] bytes)
    {
        if (id == 14)
        {

        }
    }
}
