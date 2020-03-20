using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPad : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        SoundManagerScript.PlaySound("Splash");
        Movement movement = FindObjectOfType<Movement>();
        movement.speed = 1; 
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Movement movement = FindObjectOfType<Movement>();
        movement.speed = 3f;
    }
}
