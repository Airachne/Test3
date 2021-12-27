using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateObject : MonoBehaviour
{
    XMLSettings toogleName = new XMLSettings();
    XMLSettings toogleLoad = XMLOp.Deserialize<XMLSettings>("Assets/XMLAudioSettings/audioSettings.xml"); //��������������
    [SerializeField] Toggle toogle;
    
    void Start()
    {
        ObjectState.idObject = toogleLoad.toogleName;
        ToogleState();
    }

    public void ToogleGreateGame() // ������� ��������� ���������� Togle ��� ������� �����
    {
         if (this.toogle.isOn==true)
          {
            ObjectState.idObject.Add(this.toogle.name);
   
          }
          else
          {
            ObjectState.idObject.Remove(this.toogle.name);
      
          }
        foreach (var i in ObjectState.idObject)
        {
            Debug.Log(i);
        }
     
    }
    public void ToogleState() // ������� ��������� ���������� Togle ��� ������� �����
    {
        foreach (var i in toogleLoad.toogleName) 
        if (i ==toogle.name)
        {
            toogle.isOn = true;
        }
        else
        {
            toogle.isOn = false;
         }
    }

 }
