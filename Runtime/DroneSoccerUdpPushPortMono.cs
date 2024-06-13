using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class DroneSoccerUdpPushPortMono : MonoBehaviour
{
    public int m_udpPort = 2560;

    public UdpClient m_socker;
    private IPEndPoint m_remoteEndPoint;


    public void Push(int integer)
    {
        if (m_socker != null && m_remoteEndPoint != null)
        { 
            byte[] byteData = System.BitConverter.GetBytes(integer);
            m_socker.Send(byteData, byteData.Length, m_remoteEndPoint);
        }
    }
    public void Push(byte[] byteData)
    {
        if (m_socker != null && m_remoteEndPoint != null) { 
            m_socker.Send(byteData, byteData.Length, m_remoteEndPoint);
        }
    }
    private void OnEnable()
    {
        RefreshTargetUdpIpv4();
    }

    private void RefreshTargetUdpIpv4()
    {
        KillSocket();
        m_socker = new UdpClient();
        m_remoteEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), m_udpPort);
    }

    private void OnDisable()
    {
        KillSocket();
    }

    private void OnDestroy()
    {
        KillSocket();
    }
    private void KillSocket()
    {
        if (m_socker != null)
            m_socker.Close();
    }
}
