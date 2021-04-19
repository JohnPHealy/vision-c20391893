using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Button : MonoBehaviour
{
    
    [SerializeField] private UnityEvent activate;
    [SerializeField] private UnityEvent deactivate;
    [SerializeField] public bool timerEnd;
    [SerializeField] public float timerDuration;
    private bool Color;
    private CapsuleCollider2D myCollider;
    //private Platforms platforms;
    private void Start()
    {
        timerEnd = false;
        Color = false;
        myCollider = GetComponent<CapsuleCollider2D>();
       // platforms= GameObject.FindObjectOfType<Platforms>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Color = true;
            StartCoroutine("SetTimer");
        }

        if (Color == true) 
        {
            activate.Invoke();
            myCollider.enabled = false;
            //Platforms.Active();
        }

        
        
      

    }
    
    IEnumerator SetTimer()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(timerDuration);
        timerEnd = true;
        if (timerEnd == true)
        {
            Color = false; 
        }
        
        if (Color == false)
        {
            deactivate.Invoke();
            myCollider.enabled = true;
            //Platforms.Deactive();
            Debug.Log("End");
        }
    }
}
