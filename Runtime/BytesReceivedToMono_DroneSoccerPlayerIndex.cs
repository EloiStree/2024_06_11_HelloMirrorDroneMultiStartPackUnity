using System;
using System.Collections.Generic;

public class BytesReceivedToMono_DroneSoccerPlayerIndex : AbstractBytesReceivedToMono
{


    private void Reset()
    {
        m_valideId = new byte[] { 12 };
    }

    private void Awake()
    {
        m_valideId = new byte[] { 12 };
    }

    protected override void PushInParserImplement(byte id, byte[] bytes)
    {
        if (id == 12)
        {
            int b = bytes[0];
            int j= 0;
            for (int i = 1; i < bytes.Length; i += 4)
            {
                j++;
                if(j<m_playerIntegerIndex.Count)
                {
                    m_playerIntegerIndex[j] = BitConverter.ToInt32(bytes, i);
                }
                else
                {
                    m_playerIntegerIndex.Add(BitConverter.ToInt32(bytes, i));
                }
                
            }
        }
    }
    public List<int> m_playerIntegerIndex= new List<int>();
}