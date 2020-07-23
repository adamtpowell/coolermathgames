using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keysounds : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    public AudioClip[] keyboard;
    private AudioClip clack;
    
    void Start()
    {
        keyboard = new AudioClip[]{
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-00-m-FesliyanStudios.com"),
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-01-m-FesliyanStudios.com"),
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-02-m-FesliyanStudios.com"),
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-03-m-FesliyanStudios.com"),
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-04-m-FesliyanStudios.com"),
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-05-m-FesliyanStudios.com"),
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-06-m-FesliyanStudios.com"),
            (AudioClip)Resources.Load("Sounds/Keyboard-Button-Click-07-m-FesliyanStudios.com")
        };
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B)||
    Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F)||
    Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.H)||Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.J)||
    Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L)||Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.N)||
    Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.P)||Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.R)||
    Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.T)||Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.V)||
    Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.X)||Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.Z)||
    Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)||Input.GetKeyDown(KeyCode.Tab))
     {
         int index = Random.Range(0, keyboard.Length);
         clack = keyboard[index];
         audioSource.PlayOneShot(clack);
     }
    }
}
