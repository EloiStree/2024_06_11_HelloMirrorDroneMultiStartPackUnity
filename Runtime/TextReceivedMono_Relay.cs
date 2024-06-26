using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TextReceivedMono_Relay : MonoBehaviour
{

    [TextArea(0,10)]
    public string m_receivedText = "";

    public int m_maxSizeDebugText = 1000;

    public UnityEvent<string> m_onTextReceived;
    public void PushInText(string text) {

        if (text == null) return;
        if (text.Length < m_maxSizeDebugText)
        {
            m_receivedText = text;
        }
        
        m_onTextReceived.Invoke(text);
    }
}
