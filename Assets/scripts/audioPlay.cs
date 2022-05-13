using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public AudioClip hit;
  public void playAudio(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
       DontDestroyOnLoad(gameObject);
    }
}
