using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class RotateCube : MonoBehaviour
{
    public GameObject InfoCube;
    //public Transform curentTran;
    private Animator anim;
    public Text debug; 
    private int ButtonClicked;
    private float waitTime = 1.0f;
    private float timer = 0.0f;
    private float Inversetimer = 1.0f;
    private float Key = 0.0f;
    private float nxtfirstClick = 0.0f;
    private string lastClicked; 
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
        lastClicked = "next";
        nxtfirstClick += 1.0f;
        // there are 4 stops so 0, .25, .5, .75, 1
        if (lastClicked == "prev")
        {
            Key = 1.0f - Key;
        }
        else
        { 
            if (Key == 1.0f)
            {
                Key = 0.0f;
             }
            else
            {
           
                Key += 0.25f; 
                

            }

        }
       
        
    }
    public void PreviousClicked()
    {
        ButtonClicked = -1;
        if (lastClicked == "next")
        {
            Key = 1.0f - Key;
        }
        else
        {
            if (Key == 1.0f)
            {
                Key = 0.0f;
            }
            else
            {

                Key += 0.25f;
               
 

            }
        }
        
        lastClicked = "prev";
    }
    
    public void RotChecker()
    {
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
                    anim.Play("NextAni");
                    anim.speed = 1;
                    /*switch (lastClicked)
                    {
                        case "next":
                            
                            anim.Play("NextAni");
                            anim.speed = 1;
                            break;
                        case "prev":
                            debug.text = Key.ToString();
                            anim.Play("PrevAni",0, Key);
                            anim.speed = 1;
                            break;
                    }*/

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
                    anim.Play("PrevAni");
                    anim.speed = 1;
                    /*  anim.Play("PrevAni", 0, 0.5f);
                      anim.speed = 1;
                      switch (lastClicked)
                      {
                          case "prev":

                              anim1.Rewind("NextAni");
                              anim.speed = 1;
                              break;
                          case "next":
                              debug.text = Key.ToString();
                              anim.Play("NextAni", 0, Key);
                              anim.speed = 1;
                              break;
                      }*/
                }
                break;

            default:
                anim.speed = 0;
                break;
        }

    }
}
