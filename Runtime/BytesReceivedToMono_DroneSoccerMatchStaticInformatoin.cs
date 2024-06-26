using UnityEngine;

public class BytesReceivedToMono_DroneSoccerMatchStaticInformatoin : AbstractBytesReceivedToMono
{

    private void Reset()
    {
        m_valideId = new byte[] { 10};
    }

    private void Awake()
    {
        m_valideId = new byte[] { 10 };
    }

    protected override void PushInParserImplement(byte id, byte[] bytes)
    { 
        byte b = bytes[0];
        m_maxTimingOfSet = System.BitConverter.ToSingle(bytes, 1);
        m_maxTimingOfMatch = System.BitConverter.ToSingle(bytes, 5);
        m_numberOfSetsToWinMatch = System.BitConverter.ToSingle(bytes, 9);
        m_numberOfPointsToForceWinSet = System.BitConverter.ToSingle(bytes, 13);
        m_arenaWidthMeter = System.BitConverter.ToSingle(bytes, 17);
        m_arenaHeightMeter = System.BitConverter.ToSingle(bytes, 21);
        m_arenaDepthMeter = System.BitConverter.ToSingle(bytes, 25);
        m_goalDistanceOfCenterMeter = System.BitConverter.ToSingle(bytes, 29);
        m_goalCenterHeightMeter = System.BitConverter.ToSingle(bytes, 33);
        m_goalInnerRadiusMeter = System.BitConverter.ToSingle(bytes, 37);
        m_goalSizeRadiusMeter = System.BitConverter.ToSingle(bytes, 41);
        m_goalDepthMeter = System.BitConverter.ToSingle(bytes, 45);
        m_droneSphereRadiusMeter = System.BitConverter.ToSingle(bytes, 49);
    }


    [Header("Match Info")]
    public float m_maxTimingOfSet;//300 seconds
    public float m_maxTimingOfMatch;//15 minutes
    public float m_numberOfSetsToWinMatch;//2 sets
    [Tooltip("If a team reach this points, the set is won")]
    public float m_numberOfPointsToForceWinSet;//99 points

    [Header("Dimension")]
    public float m_arenaWidthMeter;//around 7 meters
    public float m_arenaHeightMeter;//around 6 meters
    public float m_arenaDepthMeter;//around 14 meters
    public float m_goalDistanceOfCenterMeter;//4 meters+
    public float m_goalCenterHeightMeter;//3 meters
    public float m_goalInnerRadiusMeter;// 60cm+
    public float m_goalSizeRadiusMeter;///70cm+
    public float m_goalDepthMeter;//around 5-20 cm
    public float m_droneSphereRadiusMeter;//40cm 0.4 meter

}
