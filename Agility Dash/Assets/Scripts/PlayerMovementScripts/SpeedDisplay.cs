using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDisplay : MonoBehaviour
{
    private float moveSpeed;

    void Update() 
     {
         moveSpeed = GetComponent<Rigidbody>().velocity.magnitude;
     }

     void OnGUI()
     {
         GUI.Box(new Rect(10,10,100,90), "Measurements");

         GUI.Label(new Rect(20,40,80,20), moveSpeed + "m/s");
     }

}
