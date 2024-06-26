using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text.RegularExpressions;
using UnityEngine;

public class TextReceivedToMono_DroneSoccerRsaKey : MonoBehaviour
{

    [TextArea(2,6)]
    public string m_receivedText = "";


    public List<string> m_rsaString = new List<string>();

    public void PushInText(string text)
    {

        if (text == null) return;
        if (text.Length < 200) return;
        if (text.IndexOf("ClaimRSA") < 0)
            return;

        m_rsaString.Clear();
        m_receivedText = text;


        string pattern = @"<ClaimRSA>.*?<\/ClaimRSA>";

        MatchCollection matches = Regex.Matches(m_receivedText, pattern);

        foreach (Match match in matches)
        {
            m_rsaString.Add(match.Groups[0].Value
                .Replace("<ClaimRSA>", "")
                .Replace("</ClaimRSA>", "")
                .Replace("\n","")
                .Replace("\r", "")
                .Replace(" ", "")
                .Replace(" ", "")
                .Replace(" ", ""));

        }

    }
 }
