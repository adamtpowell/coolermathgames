using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherAI : MonoBehaviour
{

    int rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is just for testing out moving the teacher's FOV around and testing collisions with the computer and other things
       rotation += Random.Range(-10,10);
       transform.localRotation = Quaternion.Euler(0f, rotation, 265f);
    }
}
