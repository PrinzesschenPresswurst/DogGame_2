using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveCat : MonoBehaviour
{
    [SerializeField] float moveCatSpeed = 10;
    private float moveX;
    void Update()
    {
        PatrolCat();
    }

    void PatrolCat()
    {
        moveX = moveCatSpeed * Time.deltaTime;
        transform.Translate(0,0,moveX);
    }

    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("change direction");
        moveCatSpeed = moveCatSpeed * -1;
    }
}
