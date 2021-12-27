using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    AudioSource audioSoynd;
    [SerializeField] GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var i in ObjectState.idObject)
        {
            Debug.Log(i);
        }
        //Debug.Log(StaticK.idObject)
        Destroy(GameObject.Find("EventSystem"));
        audioSoynd = GetComponent<AudioSource>();
        Create();
    }

    // Update is called once per frame
    void Update()
    {
        audioSoynd.mute = SounMute.soundMute;
    }

    public void Create()
    {
        for (int i=0; i<prefabs.Length; i++)
        { foreach (var j in ObjectState.idObject)
            if(prefabs[i].name==j)
            {
               // Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(prefabs[i], new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
            }
        }
    }
}
