﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCount : MonoBehaviour
{

    private TextDisplay textDisplay;
    public AudioSource coinFX;
    AudioClip coinFXClip;

    void Start()
    {
        textDisplay = FindObjectOfType<TextDisplay>();
        GetComponent<AudioSource>().playOnAwake = false;
        coinFX=GetComponent<AudioSource>();
        coinFXClip = coinFX.clip;
    }

    void OnTriggerEnter2D(Collider2D collidingWith)
    {
        if (collidingWith.CompareTag("Player"))
        {
            coinFX.Play();        
            textDisplay.coinAmount++;
            Destroy(gameObject, coinFXClip.length);
        }
    }
}
