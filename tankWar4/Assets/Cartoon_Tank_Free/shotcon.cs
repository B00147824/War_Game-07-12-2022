using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotcon : MonoBehaviour
{
   
    void Start()
    {
      //bolet should shut forward 12 speed
    GetComponent<Rigidbody>().velocity = transform.forward * 12; 
    // destroy object and wiat for 5 sec
    Destroy(gameObject, 5);
    }

    void Update()

        {

        }
        
 }
