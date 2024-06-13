using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SampleMono_PushRandomGamepadPercent : MonoBehaviour
{

    public PushDroneSoccderIntAsBytesMono m_target;

    public int m_droneId20To20=-1;
    public float m_timeBetweenPushed = 0.1f;

    public IEnumerator Start() { 

        while(true) {

            if(m_target != null) {
                m_target.SetDroneId20To20(m_droneId20To20);
                m_target.SetLeftRightRotationPercent(Random.Range(-1f, 1f));
                m_target.SetDownUpPercent(Random.Range(-1f, 1f));
                m_target.SetLeftRightMovePercent(Random.Range(-1f, 1f));
                m_target.SetForwardBackwardPercent(Random.Range(-1f, 1f));
                m_target.PushAsBytes();
            }
            yield return new WaitForSeconds(m_timeBetweenPushed);
            yield return new WaitForEndOfFrame();

        }
    }

    
}
