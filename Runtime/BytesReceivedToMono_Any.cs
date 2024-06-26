using UnityEngine;

public class BytesReceivedToMono_Any : MonoBehaviour
{
    public byte m_valideId;
    public byte[] m_bytes;
    public void PushInParser(byte id, byte[] bytes)
    {
        m_valideId = id;
        m_bytes = bytes;
    }
}

