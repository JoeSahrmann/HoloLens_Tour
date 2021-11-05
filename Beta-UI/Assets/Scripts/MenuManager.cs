using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float waitTime = 1.0f;
    private float timer = 0.0f;

    //right hand
    public GameObject WorldMenuHolder;
    public GameObject RightHandMenuHolder;
    public GameObject RightPalmMenu;
    public GameObject RightOpenButton;
    public GameObject RightCloseButton;
    private Transform RightMenuStartPOS;

    //left hand
    public GameObject LeftHandMenuHolder;
    public GameObject LeftPalmMenu;
    public GameObject LeftOpenButton;
    public GameObject LeftCloseButton;
    private Transform LeftMenuStartPOS;

    private int R_Lpalm = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RightMenuStartPOS = RightPalmMenu.transform;
        LeftMenuStartPOS = LeftPalmMenu.transform;
        StickMenu2World();
        RightCheckMenuActive();
        LeftCheckMenuActive();
    }
    public void RightPalmOpened()
    {
        R_Lpalm = 1;
    }
    public void RightPalmClosed()
    {
        RightHandMenuHolder.transform.position = RightMenuStartPOS.position;
        RightHandMenuHolder.transform.rotation = RightMenuStartPOS.rotation;
        //RightHandMenuHolder.transform POSIBLY NEED SCALE
        RightHandMenuHolder.transform.SetParent(RightPalmMenu.transform);
        RightHandMenuHolder.SetActive(false);
    }
    public void LeftPalmOpened()
    {
        R_Lpalm = 2;
    }
    public void LeftPalmClosed()
    {
        LeftHandMenuHolder.transform.position = LeftMenuStartPOS.position;
        LeftHandMenuHolder.transform.rotation = LeftMenuStartPOS.rotation;
        LeftHandMenuHolder.transform.SetParent(LeftPalmMenu.transform);
        LeftHandMenuHolder.SetActive(false);
    }

    private void StickMenu2World()
    {
        switch (R_Lpalm)
        {
            //do nothing
            case 0:
                break;

            //right palm menu
            case 1:
                timer += Time.deltaTime;
                if (timer > waitTime)
                {
                    RightHandMenuHolder.transform.SetParent(WorldMenuHolder.transform);
                }
                    break;

            //left palm menu
            case 2:
                timer += Time.deltaTime;
                if (timer > waitTime)
                {
                    LeftHandMenuHolder.transform.SetParent(WorldMenuHolder.transform);
                }
                break;

            default:
                break;

        }

    }
    public void RightCheckMenuActive()
    {
        if (RightHandMenuHolder.activeInHierarchy)
        {
            RightOpenButton.SetActive(false);
            RightCloseButton.SetActive(true);
        }
        else
        {
            RightOpenButton.SetActive(true);
            RightCloseButton.SetActive(false);
        }
    }
    public void LeftCheckMenuActive()
    {
        if (LeftHandMenuHolder.activeInHierarchy)
        {
            LeftOpenButton.SetActive(false);
            LeftCloseButton.SetActive(true);
        }
        else
        {
            LeftOpenButton.SetActive(true);
            LeftCloseButton.SetActive(false);
        }
    }
}
