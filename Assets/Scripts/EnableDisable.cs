using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{

    public SpriteRenderer sr;
    public EnableDisable script;
    public GameObject go;
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //sr.enabled = false;
            go.SetActive(false);
            //script.enabled = false;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true;
            go.SetActive(true);
            //script.enabled = true;
        }
        if (Input.GetKey(KeyCode.Space) && audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(clip);
            //audioSource.Play();
        }
    }
}
