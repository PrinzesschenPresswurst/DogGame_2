using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseCats : MonoBehaviour
{
    private MeshRenderer renderer; // needs to be cached to not have to write GetComponent all the tie
    private Rigidbody rigidbody;
    [SerializeField] int catReleaseTime;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
        HideCat();
    }

    void Update()
    {
        //Debug.Log(Time.time);
        if (Time.time > catReleaseTime)
        {
            DropCat();
        }
    }

    void HideCat()
    {
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }
    
    void DropCat()
    {
        Debug.Log("release the cats");
        renderer.enabled = true;
        rigidbody.useGravity = enabled;
    }
}
