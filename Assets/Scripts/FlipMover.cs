using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class FlipMover : MonoBehaviour
{
    public AudioSource moveClickAudioSource;
    public AudioSource stopClickAudioSource;
    public AudioSource flipClickAudioSource;

    public AudioClip stopClickAudioClip;

    public List<AudioClip> flipClickAudioClips;

    public Slider staminaBar;
    public float maxStamina = 100;
    public float minStamina;
    public float staminaLoss = 10f;

    private float currentStamina;

    bool moveRight = false;
    private float speed = 1f;
    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        stopClickAudioSource.clip = stopClickAudioClip;
        currentStamina = maxStamina;
        staminaBar.value = currentStamina / maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.position += Vector3.right * (speed*direction*Time.deltaTime);

            currentStamina -= staminaLoss *Time.deltaTime;
            staminaBar.value = currentStamina / maxStamina;
            if (currentStamina <= 0)
            {
                speed = 0.1f;
            }
        }
        else
        {
            currentStamina += staminaLoss * Time.deltaTime * 2;
            staminaBar.value = currentStamina / maxStamina;
            speed = 1f;
            if(currentStamina > 100)
            {
                currentStamina = 100;
            }
        }
    }

    public void OnMoveClick()
    {
        moveRight = true;
        moveClickAudioSource.Play();
    }

    public void OnStopClick()
    {
        moveRight = false;
        stopClickAudioSource.Play();
    }
    
    public void OnFlipClick()
    {
        direction *= -1;

        //take our clips and choose one randomly
        int randomIndex = UnityEngine.Random.Range(0, flipClickAudioClips.Count);
        AudioClip randomlyChosenClip = flipClickAudioClips[randomIndex];

        flipClickAudioSource.PlayOneShot(randomlyChosenClip);
    }

    public void OnFastClick()
    {
        speed *= 1.5f;
    }
    public void OnSlowClick()
    {
        speed *= 0.75f;
    }
}
