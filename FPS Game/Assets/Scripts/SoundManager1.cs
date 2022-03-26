using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager1 : MonoBehaviour
{
    public AudioClip onClick, play;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        audioSource.PlayOneShot(onClick);
    }
    public void Play()
    {
        audioSource.PlayOneShot(play);
    }
}
