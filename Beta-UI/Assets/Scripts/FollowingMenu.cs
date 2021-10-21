using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingMenu : MonoBehaviour
{
    public Transform Menu;
    // Start is called before the first frame update
    public float posSpeed = 1.0F;
    public float rotSpeed = 1.0F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform XRcamera = Camera.main.transform;
        Vector3 newMenu = new Vector3(XRcamera.position.x + 0.15f, XRcamera.position.y , XRcamera.position.z + 0.6f);
        Menu.position = Vector3.Lerp(Menu.position, newMenu, (posSpeed * Time.deltaTime));

        // rotation movement
        Menu.rotation = Quaternion.Lerp(Menu.rotation, XRcamera.rotation, (rotSpeed * Time.deltaTime));

    }
}
