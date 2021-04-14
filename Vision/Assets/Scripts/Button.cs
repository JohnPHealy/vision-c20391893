using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Button : MonoBehaviour
{
    //[SerializeField] private LayerMask playerLayers;
    [SerializeField] private UnityEvent interacted;

    private CapsuleCollider2D myCollider;

    private void Start()
    {
        myCollider = GetComponent<CapsuleCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            interacted.Invoke();
            Debug.Log("Collided");
        }

    }
}
