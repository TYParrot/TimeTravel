using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChange : MonoBehaviour
{
    public AudioSource audioSource;
    private float duration;

    public void PlayClip(AudioClip clip, float second)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
            duration = second;
            StartCoroutine(StopClip(duration));
        }
    }
    private IEnumerator StopClip(float duration)
    {
        yield return new WaitForSeconds(duration);
        audioSource.Stop();
    }
}
