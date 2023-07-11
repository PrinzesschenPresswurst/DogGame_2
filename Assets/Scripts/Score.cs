using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cat")
        {
            score--; // same as score = score +1;
            Debug.Log("Your score is: "+ score);
        }
    }
}
