using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Audio 
{
    public string name;        //Store the name of our music/effect
    public AudioClip clip;     //Store the actual music/effect
    [Range(0f, 1f)]           
    public float volume;       //Store our volume
    [Range(0.1f, 3f)]          
    public float pitch;        // set the picth for our music/effect
    [HideInInspector]          //Hide this variable from the Editor
    public AudioSource source;// the source that will play the sound
    public bool loop = false; // should this sound loop
}
