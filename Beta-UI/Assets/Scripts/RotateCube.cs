using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public GameObject InfoCube;
    public float RotationSpeed = 1.0F;
    private bool next = false;
    private bool prev = false;
    private float yAxis; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (next)
        {
            float curYaxis = InfoCube.transform.rotation.y;
            if (curYaxis == yAxis)
            {
                next = false;
            }
            if (curYaxis != yAxis)
            {
                InfoCube.transform.Rotate(0.0f, yAxis * (RotationSpeed * Time.deltaTime), 0.0f);
                next = true;
                if(curYaxis == 90.0f)
                {
                    Debug.Log("yaxis");
                         Debug.Log("Curent Rot");
                }
            }
            
        }
        if (prev)
        {
            if (yAxis == InfoCube.transform.rotation.y)
            {
                prev = false;
            }
            if (yAxis != InfoCube.transform.rotation.y)
            {  
                InfoCube.transform.Rotate(0.0f, yAxis * (RotationSpeed * Time.deltaTime), 0.0f);
                prev = true;
            }
          
        }
    }
    public void NextClicked()
    {
        yAxis = InfoCube.transform.rotation.y;
        yAxis += 90.0f;
        next = true;
        prev = false;
        //InfoCube.transform.Rotate(0.0f, yAxis * (RotationSpeed * Time.deltaTime) , 0.0f );

    }
    public void PreviousClicked()
    {
        yAxis = InfoCube.transform.rotation.y;
        yAxis -= 90.0f;
        next = false;
        prev = true;
        //InfoCube.transform.Rotate(0.0f, yAxis * (RotationSpeed * Time.deltaTime), 0.0f);
    }
}
