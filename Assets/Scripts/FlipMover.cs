using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FlipMover : MonoBehaviour
{
    bool moveRight = false;
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            Vector3 newPosition = transform.position + Vector3.right * (speed*Time.deltaTime);
            transform.position = newPosition;
        }
    }

    public void OnMoveClick()
    {
        moveRight = true;
    }

    public void OnStopClick()
    {
        moveRight = false;
    }
    
    public void OnFlipClick()
    {
        speed *= -1;
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
