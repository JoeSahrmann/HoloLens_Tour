using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject DiscoveryCardHolder;
    public GameObject ExplorerCardHolder;
    public GameObject MRTKSceneContent;
    public GameObject RightPalmMenu;
    public GameObject LeftPalmMenu;
    private Transform XRcamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         XRcamera = Camera.main.transform;
        //if +5Xrcamera.x > carholder.x || -5Xrcamera.x < carholder.x || +5Xrcamera.z > carholder.z || -5Xrcamera.z < carholder.z
        // ResetDiscoveryCardHolder();
        // ResetExplorerCardHolder();
    }
    public void MoveDiscoveryCardHolder()
    {
        DiscoveryCardHolder.transform.SetParent(MRTKSceneContent.transform);
    }
    public void MoveExplorerCardHolder()
    {
        ExplorerCardHolder.transform.SetParent(MRTKSceneContent.transform);
    }
    public void ResetDiscoveryCardHolder()
    {
       // DiscoveryCardHolder.SetActive(false);
        DiscoveryCardHolder.transform.SetParent(RightPalmMenu.transform);
    }
    public void ResetExplorerCardHolder()
    {
        //ExplorerCardHolder.SetActive(false);
        ExplorerCardHolder.transform.SetParent(LeftPalmMenu.transform);
    }

}
