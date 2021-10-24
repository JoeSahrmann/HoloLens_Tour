using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideInCards : MonoBehaviour
{
    public GameObject CardHolder;
    private Animator anim;
    private int buttonClicked;
    private float waitTime = 1.0f;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = CardHolder.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationStarter();
    }
    public void LeftPalmButtonClicked()
    {
        buttonClicked = 0;

    }
    public void RightPalmButtonClicked()
    {
        buttonClicked = 1;

    }
    void AnimationStarter()
    {
        switch (buttonClicked)
        {
            case 0:
                timer += Time.deltaTime;

                if (timer > waitTime)
                {
                    // Remove the recorded 1 seconds.
                    timer = timer - waitTime;
                    buttonClicked = 0;
         
                }
                else
                {
                    anim.Play("LeftPalmSlide");
                    anim.speed = 1;

                }
                break;
            case 1:
                timer += Time.deltaTime;

                if (timer > waitTime)
                {
                    // Remove the recorded 1 seconds.
                    timer = timer - waitTime;
                    buttonClicked = 0;
                    
                }
                else
                {
                    anim.Play("RightPalmSlide");
                    anim.speed = 1;

                }
                break;
            default:
                anim.speed = 0;
                break;
        }

    }
}
