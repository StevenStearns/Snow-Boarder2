using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float fltLoadDelay = 1f;
    [SerializeField] ParticleSystem finisheffect;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finisheffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", fltLoadDelay);
            
         
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

