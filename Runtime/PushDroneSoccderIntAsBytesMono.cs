using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushDroneSoccderIntAsBytesMono : MonoBehaviour
{

    public int m_lastIntegerPushed;
    public byte[] m_lastBytesPushed;
    public UnityEvent<byte[]> m_onBytePush;

    public DroneGamepad m_gamepad;
    public int m_droneId20To20;

    public void SetLeftRightRotationPercent(float percent)
    {
        m_gamepad.m_joystickLeftX_rotatreLeftRight = percent;
    }
    public void SetDownUpPercent(float percent)
    {
        m_gamepad.m_joystickLeftY_moveDownUp = percent;
    }
    public void SetLeftRightMovePercent(float percent)
    {
        m_gamepad.m_joystickRightX_moveLeftRight = percent;
    }
    public void SetForwardBackwardPercent(float percent)
    {
        m_gamepad.m_joystickRightY_moveForwardBackward = percent;
    }
    public void SetDroneId20To20(int droneId20To20)
    {
        m_droneId20To20= Mathf.Clamp(droneId20To20, -20, 20);
    }

    public void PushAsBytes()
    {
        DroneSoccerIntUtility.ParseToInteger(
            m_droneId20To20,
            m_gamepad.m_joystickLeftX_rotatreLeftRight,
            m_gamepad.m_joystickLeftY_moveDownUp,
            m_gamepad.m_joystickRightX_moveLeftRight,
            m_gamepad.m_joystickRightY_moveForwardBackward,
            out int commandAsInt
            );
        m_lastIntegerPushed = commandAsInt;
        byte  [] bytes = System.BitConverter.GetBytes(commandAsInt);
        m_lastBytesPushed = bytes;
        m_onBytePush.Invoke(bytes);
    }    

}


[System.Serializable]
public struct DroneGamepad { 

    public float m_joystickLeftX_rotatreLeftRight;
    public float m_joystickLeftY_moveDownUp;
    public float m_joystickRightX_moveLeftRight;
    public float m_joystickRightY_moveForwardBackward;
}
