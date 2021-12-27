using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    AudioSource audioSoynd;
    XMLSettings sound = XMLOp.Deserialize<XMLSettings>("Assets/XMLAudioSettings/audioSettings.xml"); //��������������
    XMLSettings xMLSettings;
    public Toggle toogle;

    private void Awake()
    {
        audioSoynd = GetComponent<AudioSource>(); 
        audioSoynd.ignoreListenerPause = true; // ������������� ListenerPause
        SounMute.soundMute = sound.audioSettings; // ������������ �������� �� ������������ ������
    }
    // Start is called before the first frame update
    void Start()
    {
        ToogleState(); // ������� ��������� ���������� Togle
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SounMute.soundMute);
    }

    public void SounGameMute()  // ���� toogl on �� ���� ������� ���� ��� �� ��������
    {
        if (!audioSoynd.mute)
        {
            audioSoynd.mute = SounMute.soundMute = true;
        }
        else
        {
            audioSoynd.mute = SounMute.soundMute = false;
        }
        Debug.Log(SounMute.soundMute);

    }

     private void ToogleState() // ������� ��������� ���������� Togle ��� ������� �����

    {
        if (SounMute.soundMute == true)
        {
            toogle.isOn = false;
            audioSoynd.mute = SounMute.soundMute = true;
        }
        else
        {
            toogle.isOn = true;
            audioSoynd.mute = SounMute.soundMute = false;
        }
    }

}
