using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    AudioSource audioSoynd;
    XMLSettings sound = XMLOp.Deserialize<XMLSettings>("Assets/XMLAudioSettings/audioSettings.xml"); //десериализация
    XMLSettings xMLSettings;
    public Toggle toogle;

    private void Awake()
    {
        audioSoynd = GetComponent<AudioSource>(); 
        audioSoynd.ignoreListenerPause = true; // игнорирование ListenerPause
        SounMute.soundMute = sound.audioSettings; // присваивание значения из статического класса
    }
    // Start is called before the first frame update
    void Start()
    {
        ToogleState(); // функция состояния компонента Togle
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SounMute.soundMute);
    }

    public void SounGameMute()  // если toogl on то звук включён если нет то выключен
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

     private void ToogleState() // функция состояния компонента Togle при старете сцены

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
