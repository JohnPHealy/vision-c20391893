using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Timer : MonoBehaviour
{

    // Start is called before the first frame update
    //public static bool timerIsRunning = false;

    private IEnumerator coroutine;
    void Start()
    {

        coroutine = WaitandPrint(2.0f);
        StartCoroutine(coroutine);
        print("Starting"+Time.time);
    }


    private IEnumerator WaitandPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint"+ Time.time);
        }
    }

    // Update is called once per frame
       /* void Update()
        {
            if (timerIsRunning)
            {

                
            }
            else
            {
                Debug.Log("Time up");
                timerIsRunning = false;

            }
        }
    }
    */
}
       
    

