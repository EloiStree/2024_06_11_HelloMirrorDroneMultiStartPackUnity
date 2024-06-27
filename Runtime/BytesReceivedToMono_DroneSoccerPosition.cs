using UnityEngine;



public class BytesReceivedToMono_DroneSoccerPosition : AbstractBytesReceivedToMono
{

    private void Reset()
    {
        m_valideId = new byte[] { 1 };
    }

    private void Awake()
    {
        m_valideId = new byte[] { 1 };
    }

    protected override void PushInParserImplement(byte id, byte[] bytes)
    {
        //    if (id == 1)
        //    {
        //        long timeServer = System.BitConverter.ToInt64(bytes, 1);
        //        long frameId = System.BitConverter.ToInt64(bytes, 9);

        //        m_dronePositionRecevied.m_frameId = frameId;
        //        m_dronePositionRecevied.m_timeServer = timeServer;

        //        for (int i = 17, j = 0; i < bytes.Length; i += 9, j++)
        //        {
        //            //while (j >= m_dronePositionRecevied.m_drones.Count)
        //            //{
        //            //    DroneSoccerPosition position = new DroneSoccerPosition();
        //            //    m_dronePositionRecevied.m_drones.Add(position);
        //            //    position.m_indexId_0_11 = j;
        //            //    position.m_droneId_1_12 = j + 1;
        //            //}
        //            //DroneSoccerPosition drone = m_dronePositionRecevied.m_drones[j];

        //            drone.m_position = new Vector3(
        //                 (System.BitConverter.ToInt16(bytes, i)) / 1000f,
        //                 (System.BitConverter.ToInt16(bytes, i + 2)) / 1000f,
        //                 (System.BitConverter.ToInt16(bytes, i + 4)) / 1000f
        //                );
        //            drone.m_rotation = Quaternion.Euler(
        //                bytes[i + 6] / 255f * 360f,
        //                bytes[i + 7] / 255f * 360f,
        //                bytes[i + 8] / 255f * 360f
        //                );
        //        }
        //    }
        //}
        //public DronePositionsFrame m_dronePositionRecevied;
    }
}
