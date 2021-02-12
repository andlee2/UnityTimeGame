using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

        public Rigidbody2D rb;
        //public Animator animator;


        Vector2 movement;


        // Update is called once per frame
        void Update()
        {
            //Input
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            
            if (movement != Vector2.zero){
                //animator.SetFloat("Horizontal", movement.x);
                //animator.SetFloat("Vertical", movement.y);
                if (movement.x < 0) {
                    transform.localScale = new Vector2(-1, 1);
                }
                else {
                    transform.localScale = new Vector2(1,1);
                
                }

            }
            


            //animator.SetFloat("Speed", movement.sqrMagnitude);
            
        
        }

        void FixedUpdate()
        {
            // Movement
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        

        }
}
