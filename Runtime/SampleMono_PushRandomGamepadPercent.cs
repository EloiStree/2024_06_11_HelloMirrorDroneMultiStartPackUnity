using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SampleMono_PushRandomGamepadPercent : MonoBehaviour
{

    public int m_droneId20To20=-1;
    public float m_timeBetweenPushed = 0.1f;


    public UnityEvent<int> m_setDroneId;
    public UnityEvent<float> m_setLeftRightRotationPercent;
    public UnityEvent<float> m_setDownUpPercent;
    public UnityEvent<float> m_setLeftRightMovePercent;
    public UnityEvent<float> m_setBackwardForwardPercent;
    public UnityEvent m_onFinishSettingGamepad;

    public IEnumerator Start() { 

        while(true) {

                m_setDroneId.Invoke(m_droneId20To20);
                m_setLeftRightRotationPercent.Invoke(Random.Range(-1f, 1f));
                m_setDownUpPercent.Invoke(Random.Range(-1f, 1f));
                m_setLeftRightMovePercent.Invoke(Random.Range(-1f, 1f));
                m_setBackwardForwardPercent.Invoke(Random.Range(-1f, 1f));
                m_onFinishSettingGamepad.Invoke();
            
            yield return new WaitForSeconds(m_timeBetweenPushed);
            yield return new WaitForEndOfFrame();

        }
    }

    
}
