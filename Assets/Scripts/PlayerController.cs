using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float fltTorqueAmount = 1f;
    [SerializeField] float fltBoostSpeed = 30f;
    [SerializeField] float fltBaseSpeed = 20f;
    SurfaceEffector2D surfaceEffector2D;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
      
    } // void update

    void RespondToBoost()
    {
        // if we push up speed up
        // otherwise stay at normal speed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = fltBoostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = fltBaseSpeed;
        }
    }

    void RotatePlayer()
    {
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(fltTorqueAmount);
        }
            else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-fltTorqueAmount);
        }
    }
}
