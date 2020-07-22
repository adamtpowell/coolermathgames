using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class PCPC : MonoBehaviour
{

    public GameObject chrome;
    private int step;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step++;
        chrome.transform.position = new Vector3((float) Math.Sin(step / 100.0) * 2.0f, (float) Math.Cos(step / 100.0) * 2.0f, 0.0f);
    }
}
