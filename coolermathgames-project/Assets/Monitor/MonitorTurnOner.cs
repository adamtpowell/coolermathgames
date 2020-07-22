using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorTurnOner : MonoBehaviour
{

    public int offsetX = 10;
    public int offsetY = 10;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 curOffset = new Vector3(0, 0, 0);
        GameObject[] monitors = GameObject.FindGameObjectsWithTag("Monitor");
        foreach (GameObject monitor in monitors)
        {
            curOffset += new Vector3(offsetX, offsetY, 0);
            monitor.GetComponent<MonitorController>().SetupScreen(curOffset);
        }
    }
}
