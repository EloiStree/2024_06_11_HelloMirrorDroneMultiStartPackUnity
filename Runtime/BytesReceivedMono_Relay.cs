using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BytesReceivedMono_Relay : MonoBehaviour
{

    public byte[] m_bytesReceived;
    public int m_limitToDispalyInInspector = 200;
    public UnityEvent<byte[]> m_onBytesPushed;

    public void PushBytesReceivedIn(byte[] bytes)
    {
        if(bytes.Length < m_limitToDispalyInInspector)
        {
            m_bytesReceived = bytes;
        }
        m_onBytesPushed.Invoke(bytes);
    }
}
