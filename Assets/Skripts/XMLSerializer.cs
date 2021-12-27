using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class XMLSerializer : MonoBehaviour
{
    XMLSettings audioSettings = new XMLSettings();

    public void OnApplicationQuit()
    {
        SaveSound();
    }

    public void SaveSound()
    {
        audioSettings.audioSettings = SounMute.soundMute;
        audioSettings.toogleName = ObjectState.idObject;
        XMLOp.Serialize(audioSettings, "Assets/XMLAudioSettings/audioSettings.xml");
    }

}
