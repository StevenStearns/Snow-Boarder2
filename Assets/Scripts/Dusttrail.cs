using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusttrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dusParticles;
    
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            dusParticles.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            dusParticles.Stop();
        }
    }
    
}
