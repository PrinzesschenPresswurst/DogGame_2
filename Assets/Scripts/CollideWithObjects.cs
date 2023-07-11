using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithObjects : MonoBehaviour
{
    [SerializeField] private Color bumpColor;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = bumpColor;
            gameObject.tag = "Untagged";
        }
    }
}
