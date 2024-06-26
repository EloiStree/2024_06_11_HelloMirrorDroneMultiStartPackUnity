using System;

public class BytesReceivedToMono_DroneSoccerMatchState : AbstractBytesReceivedToMono
{

    private void Reset()
    {
        m_valideId = new byte[] { 3 };
    }

    private void Awake()
    {
        m_valideId = new byte[] { 3 };
    }

    protected override void PushInParserImplement(byte id, byte[] bytes)
    {
        if (id == 3)
        {
            
            byte b= bytes[0];
            m_redPoints = BitConverter.ToInt32(bytes, 1);
            m_bluePoints = BitConverter.ToInt32(bytes, 5);
            m_redSets = BitConverter.ToInt32(bytes, 9);
            m_blueSets = BitConverter.ToInt32(bytes, 13);
            m_utcTicksServerTimeMatchStarted = BitConverter.ToInt64(bytes, 17);
            m_utcTicksServerTimeSetFinished = BitConverter.ToInt64(bytes, 25);

         }
    }


    public int m_redPoints;
    public int m_bluePoints;
    public int m_redSets;
    public int m_blueSets;
    public long m_utcTicksServerTimeMatchStarted;
    public long m_utcTicksServerTimeSetFinished;

}
