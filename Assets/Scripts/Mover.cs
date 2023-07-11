using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    //private float moveX;
    //private float moveZ;
    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal") *Time.deltaTime *moveSpeed;
        float moveZ = Input.GetAxis("Vertical") *Time.deltaTime *moveSpeed;
        transform.Translate(moveX,0,moveZ);
    }
}
