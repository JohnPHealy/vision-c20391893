using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    //[SerializeField] private UnityEvent interacted;
    
    
    private Vector3 startPos;
    private int score;

    private void Start()
    {
        startPos = player.transform.position;
       
    }

    public void RespawnPlayer()
    {
        player.transform.position = startPos;
        //interacted.Invoke();
       
    }

    public void AddScore(int scoreAmt)
    {
    }

    

  

}