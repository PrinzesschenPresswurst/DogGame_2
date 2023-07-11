using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class DogFlash : MonoBehaviour
{
    public Material flashMaterial;
    
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("bump"))
        {
            foreach (Transform child in transform)
            {
                Renderer childRenderer = child.GetComponent<Renderer>();
                if (childRenderer != null)
                {
                    // Change the material of each child object
                    childRenderer.material = flashMaterial;
                }
            } 
        }
    }
}
