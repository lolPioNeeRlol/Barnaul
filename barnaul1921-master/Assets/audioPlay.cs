using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        AudioListener.pause = false;
        AudioSource music = other.gameObject.GetComponent<AudioSource>();
        //AudioListener myListener = GetComponent<AudioListener>();
    
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
