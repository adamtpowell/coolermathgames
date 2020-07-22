using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorController : MonoBehaviour {


    public GameObject OSPrefab;

    // Create a camera / OSController / rendertexture to use for this monitor, then assign it.
    // Called by ComputerTurnOner to populate every monitor in the scene.
    public void SetupScreen(Vector3 offset)
    {
        // Create an instance of the chosen OS
        GameObject OS = Instantiate(OSPrefab, offset, Quaternion.identity);
        
        // Assign the render texture to place the OS onto the monitor
        RenderTexture rt = new RenderTexture(320, 240, 16, RenderTextureFormat.ARGB32);
        rt.filterMode = FilterMode.Point;
        OS.transform.Find("camera").GetComponent<Camera>().targetTexture = rt;
        this.GetComponent<MeshRenderer>().sharedMaterial.mainTexture = rt;
    }
}
