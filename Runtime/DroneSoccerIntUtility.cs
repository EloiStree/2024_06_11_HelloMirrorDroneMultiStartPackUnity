using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSoccerIntUtility 
{


    public static void ParseToInteger(int droneId20To20, float rotationLeftRight, float moveDownUp, float moveLeftRight, float moveBackForward, out int intCommand)
    {
        int droneId = droneId20To20;
        intCommand = 0;
        intCommand+= ParseFloatTo99Digits(rotationLeftRight)* 1000000;
        intCommand+= ParseFloatTo99Digits(moveDownUp) * 10000;
        intCommand+= ParseFloatTo99Digits(moveLeftRight) * 100;
        intCommand+= ParseFloatTo99Digits(moveBackForward) *1 ;
        if(droneId20To20<0)
            intCommand= -( Mathf.Abs(intCommand) + droneId*100000000 );
        else 
            intCommand= intCommand+ droneId*100000000;
    }

    public static void ParseFloatTo99Digits(float value, out int int99)
    {
        int99 = ParseFloatTo99Digits(value);
    }
    public static int ParseFloatTo99Digits(float value)
    {
        value= Mathf.Clamp(value, -1f, 1f);
        if (value == 0)
            return 0;
        return (int) ( ( (value + 1f ) / 2f * 98f)+1f);
    }
    
}
