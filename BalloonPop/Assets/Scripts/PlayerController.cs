using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
   private float speed = 20.0f;
   private float turnSpeed = 45.0f;
   private float horizontalInput;
   private float forwardInput;

   private void Start()
   {
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
      
      transform.Translate(Vector3.forward*Time.deltaTime*speed);
      transform.Rotate(Vector3.up, turnSpeed*Time.deltaTime*speed);

   }

}
