using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float fltTorqueAmount = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // move character left and right while in the air.
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
