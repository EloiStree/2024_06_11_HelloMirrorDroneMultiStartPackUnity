public class BytesReceivedToMono_DroneSoccerTimeValue : AbstractBytesReceivedToMono
{

    private void Reset()
    {
        m_valideId = new byte[] { 2 };
    }

    private void Awake()
    {
        m_valideId = new byte[] { 2 };
    }

    protected override void PushInParserImplement(byte id, byte[] bytes)
    {
        if (id == 2)
        {
            m_secondsSinceMatchStarted = System.BitConverter.ToInt32(bytes, 1);
            m_secondsSinceSetStarted = System.BitConverter.ToInt32(bytes, 5);
            m_timeOfServerDateTimUtcNowTick = System.BitConverter.ToInt64(bytes, 9);
        }
        
    }

       public long m_secondsSinceMatchStarted;
       public long m_secondsSinceSetStarted;
       public long m_timeOfServerDateTimUtcNowTick;
}
