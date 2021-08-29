using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static SoundManager instance;
    [SerializeField]
    private AudioSource soundFx=null;
    [SerializeField]
    private AudioClip landclip=null, deathclip=null, icebreakclip=null, gameoverclip=null;
    private void Awake()
    {
        if (instance == null)
            instance = this;

    }
    public void LandSound()
    {
        soundFx.clip = landclip;
        soundFx.Play();
    }
    public void Icebreaksound()
    {
        soundFx.clip = icebreakclip;
        soundFx.Play();
    }
    public void Deathsound()
    {
        soundFx.clip = deathclip;
        soundFx.Play();
    }
    public void Gameoversound()
    {
        soundFx.clip = gameoverclip;
        soundFx.Play();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
