using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class PCPC : MonoBehaviour
{

    public GameObject chrome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chrome.transform.Translate(new Vector3(0.01f, 0.01f, 0.01f));
    }
}
