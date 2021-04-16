using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Button : MonoBehaviour
{
    
    [SerializeField] private UnityEvent activate;
    [SerializeField] private UnityEvent deactivate;

    private CapsuleCollider2D myCollider;

    private void Start()
    {
        myCollider = GetComponent<CapsuleCollider2D>();
         Timer timer = FindObjectOfType<Timer>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            activate.Invoke();
            myCollider.enabled = false;
            Debug.Log("Collided");
            Timer.timerIsRunning =true;
        }

        if (Timer.timerIsRunning==false)
        {
           deactivate.Invoke();
       }
        
    }
}
