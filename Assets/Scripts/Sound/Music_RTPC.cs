using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_RTPC : MonoBehaviour
{
    public AK.Wwise.RTPC MusicVolumn;

    public void MusicVolumnRTPC(float value)
    {
        AkUnitySoundEngine.SetRTPCValue(MusicVolumn.Id, value);
    }
}
