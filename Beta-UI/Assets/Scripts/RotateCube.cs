using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class RotateCube : MonoBehaviour
{
    public GameObject InfoCube;
    public Transform curentTran;
    private Animator anim;
    // private Quaternion currentRot;
    private float tempCurRot;
    private float nextTurn = 0.0f;
    private float lastTurn = 0.0f;
    //new way
    private int ButtonClicked;
    private float waitTime = 1.0f;
    private float timer = 0.0f;
    private float Inversetimer = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = InfoCube.gameObject.GetComponent<Animator>();
        
    }
    // Update is called once per frame
    void Update()
    {
        RotChecker();
        if (Input.GetKeyDown(KeyCode.J))
        {
            
            anim.Play("NextAni");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {

            anim.enabled = false;
        }
       
    }
    public void NextClicked()
    {
        ButtonClicked = 1;
        Debug.Log("clicked");
       /* anim.Play("NextAni");
        if (nextTurn >= 360.0f)
        {
            nextTurn = 0.0f;
        }
        else
        {
            float stopRot = 90.000000001f;
            tempCurRot = curentTran.eulerAngles.y;
            nextTurn = stopRot + tempCurRot;
            anim.speed = 1;
            //anim.Play("MoveCube");



        }*/
        
        //Debug.Log("stopRot:  ", stopRot.ToString());
    }
    public void PreviousClicked()
    {
        ButtonClicked = -1;
       /* anim.Play("NextAni");
        if (lastTurn >= -360.0f)
        {
            lastTurn = 0.0f;
        }
        else
        {
            float stopRot = -90.000000001f;
            tempCurRot = curentTran.eulerAngles.y;
            lastTurn = stopRot + tempCurRot;
            
            //anim.Play("MoveCube");
            


        }*/
    }
    
    public void RotChecker()
    {


        /*| nextTurn == 180.0f | nextTurn == 270.0f | nextTurn == 360.0f
        if (curentTran.eulerAngles.y > nextTurn )
        {
            Debug.Log("should stop");
            anim.speed = 0;
        }*/
        switch (ButtonClicked)
        {
            case 1:
                timer += Time.deltaTime;
                
                if (timer > waitTime)
                {
                    // Remove the recorded 1 seconds.
                    timer = timer - waitTime;
                    ButtonClicked = 0;
                    Inversetimer = 1.0f;
                }
                else
                {
                    Inversetimer -= timer;
                    anim.Play("NextAni");
                    anim.speed = 1;
                }
                break;

            case 0:
                anim.speed = 0;
                break;

            case -1:
                timer += Time.deltaTime;

                if (timer > waitTime)
                {
                    // Remove the recorded 1 seconds.
                    timer = timer - waitTime;
                    ButtonClicked = 0;
                    Inversetimer = 1.0f;
                }
                else
                {
                    Inversetimer -= timer;
                    anim.Play("PrevAni");
                    anim.speed = 1;
                }
                break;

            default:
                anim.speed = 0;
                break;
        }

    }
}
