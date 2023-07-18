using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip SE;
    public AudioClip buttonClickSE;
    public AudioSource audioPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playbookSE()
    {
        audioPlayer.PlayOneShot(SE);
    }
    public void playbuttonSE()
    {
        audioPlayer.PlayOneShot(buttonClickSE);
    }
    public void pauseTheMusic()
    {
        AudioListener.pause = true;
    }
}
