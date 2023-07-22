using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    public Audio[] playlist;
    public Audio[] sounds;
    //public AudioSource audioSource;

    private int currentPlayingIndex = 999;

    public static AudioManager instance;
    private bool shouldPlayMusic = false;

    private float musicVol;
    private float effectsVol;

    private void Start()
    {
        PlayMusic();
    }
    private void createAudioSources(Audio[] sounds, float volume)
    {
        foreach (Audio a in sounds)
        {   
            a.source = gameObject.AddComponent<AudioSource>(); // create anew audio source(where the sound splays from in the world)
            a.source.clip = a.clip;     // the actual music/effect clip
            a.source.volume = a.volume * volume; // set volume based on parameter
            a.source.pitch = a.pitch;   // set the pitch
            a.source.loop = a.loop;     // should it loop
        }
    }

    private void Awake()
    {

        if (instance == null)
        {     
            instance = this;        //save this AudioManager in instance 
        }
        else
        {
            Destroy(gameObject);    
            return;                
        }

        DontDestroyOnLoad(gameObject); 

        
        musicVol = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        effectsVol = PlayerPrefs.GetFloat("EffectsVolume", 0.75f);

        createAudioSources(sounds, effectsVol);
        createAudioSources(playlist, musicVol);   

    }
    public void PlayMusic()
    {
        if (shouldPlayMusic == false)
        {
            shouldPlayMusic = true;
            // pick a random song from our playlist
            currentPlayingIndex = UnityEngine.Random.Range(0, playlist.Length - 1);
            playlist[currentPlayingIndex].source.volume = playlist[0].volume * musicVol; // set the volume
            playlist[currentPlayingIndex].source.Play(); // play it
        }
    }
    // stop music
    public void StopMusic()
    {
        if (shouldPlayMusic == true)
        {
            shouldPlayMusic = false;
            currentPlayingIndex = 999; // reset playlist counter
        }
    }

    void Update()
    {
       
        if (currentPlayingIndex != 999 && !playlist[currentPlayingIndex].source.isPlaying)
        {
            currentPlayingIndex++; // set next index
            if (currentPlayingIndex >= playlist.Length)
            { //have we went too high
                currentPlayingIndex = 0; 
            }
            playlist[currentPlayingIndex].source.Play();
        }
    }

    
    public String getSongName()
    {
        return playlist[currentPlayingIndex].name;
    }

    // if the music volume change update all the audio sources
    public void musicVolumeChanged()
    {
        foreach (Audio a in playlist)
        {
            musicVol = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
            a.source.volume = playlist[0].volume * musicVol;
        }
    }

    //if the effects volume changed update the audio sources
    public void effectVolumeChanged()
    {
        effectsVol = PlayerPrefs.GetFloat("EffectsVolume", 0.75f);
        foreach (Audio a in sounds)
        {
            a.source.volume = a.volume * effectsVol;
        }
        sounds[0].source.Play(); // play an effect so user can her effect volume
    }
}
