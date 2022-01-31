using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource;
    public Slider sliderVolume;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.volume = PlayerPrefs.GetFloat("volume");

        if(sliderVolume != null)
        {
            sliderVolume.value = audioSource.volume;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("volume", audioSource.volume);

    }
}
