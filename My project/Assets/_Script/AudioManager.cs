using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource bgSource;
    public AudioSource eddectSource;
    public AudioClip jump;
    public AudioClip coin;

    public Slider volumeSlider;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Start()
    {
        volumeSlider.value = bgSource.volume;
    }
    void Update()
    {

    }
    public void PlayJump()
    {
      PlaySound(jump);
    }
    public void PlayCoin()
    { 
        PlaySound(coin);
    }
    public void ChangeVolume()
    {
        bgSource.volume = volumeSlider.value;
    }
    private void PlaySound(AudioClip clip)
    {
        eddectSource.PlayOneShot(clip);
    }
}
