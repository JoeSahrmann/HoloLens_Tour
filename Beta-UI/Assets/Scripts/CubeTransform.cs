using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransform : MonoBehaviour
{// the parent object f cube is POS is 
    //x = -2.133579
    //y = 2.174208
    //z = -2.58185
    public GameObject ProgressCube;
    // Start is called before the first frame update
    void Start()
    {
        ProgressCube.transform.position = new Vector3( 0.0f,  0.0f,  0.0f);
    }
    public void ResetPOS()
    {
        ProgressCube.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
    public void HomeClick()
    {
        //-2.429f, 2.416f,  -1.785f
        ProgressCube.transform.position = new Vector3( -0.295421f, 0.241792f,  0.79685f);
        Debug.Log("button 1 clicked");
     }
    public void ProjectClick()
    {
        ProgressCube.transform.position = new Vector3( -0.006421f, 0.241792f, 0.79685f);
    }
    public void InfoClick()
    {
        ProgressCube.transform.position = new Vector3( 0.224579f, 0.241792f, 0.79685f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
