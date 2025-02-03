using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBat : MonoBehaviour
{
   [SerializeField]
   private float jumpForce = 500f;

    private void Update()
    {
       if(Input.GetButtonDown("Fire1"))
       {
           GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
       } 
    }
}
