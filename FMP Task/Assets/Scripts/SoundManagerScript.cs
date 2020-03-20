using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip coinSound, splashSound;
    static AudioSource audioSrc;

    void Start()
    {
        coinSound = Resources.Load<AudioClip>("Coins");
        splashSound = Resources.Load<AudioClip>("Splash");


        audioSrc = GetComponent<AudioSource>();
    }


    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Coins":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "Splash":
                audioSrc.PlayOneShot(splashSound);
                break;




        }
    }
}
