using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDelay : MonoBehaviour
{
    public float delay = 0f;
     public AudioClip otherClip;

    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.PlayDelayed(delay);
        yield return new WaitForSeconds(audio.clip.length);
    }
}
