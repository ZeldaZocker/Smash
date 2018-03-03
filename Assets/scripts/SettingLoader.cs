using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingLoader : MonoBehaviour {

    public bool musicEnabled;


    void Update()
    {
        if (!GameObject.Find("MusicPlayer").GetComponent<MusicScript>().m_Play)
        {
            PlayerPrefs.SetInt("musicEnabled", 0);
            Debug.Log("Saved: False!");
        }
        else
        {
            PlayerPrefs.SetInt("musicEnabled", 1);
            Debug.Log("Saved: True!");
        }
    }


    void Start () {
        if (PlayerPrefs.GetInt("musicEnabled") == 0)
        {
            musicEnabled = false;
            Debug.Log("Loaded: False!");
        }

        else if (PlayerPrefs.GetInt("musicEnabled") == 1)
        {
            musicEnabled = true;
            Debug.Log("Loaded: True!");
        }

        if (musicEnabled == false)
        {
            GameObject.Find("MusicPlayer").GetComponent<MusicScript>().m_Play = false;
            GameObject.Find("MusicPlayer").GetComponent<MusicScript>().m_ToggleChange = false;
            GameObject.Find("MusicPlayer").GetComponent<MusicScript>().m_MyAudioSource.Stop();
        }

    }

}
