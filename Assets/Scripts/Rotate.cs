using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float catRotateSpeed = 0.1f;
    //float rotateY;
    
    void Update()
    {
        RotateCat();
    }

    void RotateCat()
    {
        float rotateY = catRotateSpeed * Time.deltaTime;
        transform.Rotate(0,rotateY,0);
    }
}
