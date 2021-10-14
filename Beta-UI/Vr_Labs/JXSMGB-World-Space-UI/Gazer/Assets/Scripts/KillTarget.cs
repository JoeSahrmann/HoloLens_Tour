using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillTarget : MonoBehaviour
{
    //gazer lazer 
   
    public GameObject target; //creates a gameobject that is to be the target i.e. Ethan
    public float timeToSelect = 3.0f; //set the amount of time a user must look before destroyed/respwaned
    public ParticleSystem hitEffect; //set the effect when the user is looking at Ethan
    public GameObject killEffect; //set the effect of when the target has been destroyed/respwaned
    
    private float countDown; //used for logic down on so that it keeps track of how long the user stares
    private int score;//this is used to keep track of how many times the user D/r Ethan
    public Text scoreText;// creates a text object that will display score in the game 
    // private var emission = hitEffect.emission;
    void Start()
    {
        //this is all the stuff used to initiate the spark emitter 
       // hitEffect.enableEmission = false;
        var emission = hitEffect.emission;
        emission.enabled = false;
    //
        countDown = timeToSelect; //sets the countdown time to 3.0f
        score = 0; //set initial score to 0
    }

    void Update()
    {
       scoreText.text = "" + score; //sets Score text to whatever the score is every frame update
        var emission = hitEffect.emission;
        Transform camera = Camera.main.transform;//this set the camera to the headset
        Ray ray = new Ray(camera.position, camera.transform.rotation * Vector3.forward);//this sends out a ray into the world
        RaycastHit hit;
        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100.0f, Color.cyan, 1, true); //this visualizes the ray cast so you can see it in the scene view
        if (Physics.Raycast(ray, out hit) && (hit.collider.gameObject == target))//This states if the ray cast hits the target
        {
           
            if (countDown < 0f)//if the user has been staring at the target for the whole countdown time given then D/R Ethan
            {
                //ToDo: Kill target.Instantiate kill Effect. Reset the countdown. 
                // Instantiate(killEffect, target.transform.position, target.transform.rotation);

                target.SetActive(false);//makes the target go invisible
                RespawnTarget(target);//explodes and relocates the target does not destroy it
            }
            else//if the countdown not at 0 then do this
            {
                //ToDo: Decrement countdown with Time.deltaTime amount. Enable the hitEffect, and place it at hit.ponit.
                HitTarget(hit.point);//this enables the spark emiter at the hiteffect point
                countDown -= Time.deltaTime;// this decrements the countdown 

               // hitEffect.transform.position = hit.point;
               // emission.enabled = true;
            }
        }
        else//this resets the count and stops the effect if raycast not on target
        {
            //ToDo: Reset countdown. Disable hitEffect.
           // emission.enabled = false;

            countDown = timeToSelect;
            emission.enabled = false;
        }
        
    }

    void RespawnTarget(GameObject target)
    {
        //kill Effect Instantiate, put on to the position of Ethan
        Instantiate(killEffect, target.transform.position, target.transform.rotation);
        score++;//increments the score for however many times the player d/r Ethan

        //this respawns the target ethan at a new location
        RandomPosition();//this relocates Ethan
      
    }
  
    void HitTarget(Vector3 hitpoint)
    {
       
        hitEffect.transform.position = hitpoint;
        var emission = hitEffect.emission;
        emission.enabled = true;
    }
    void RandomPosition()
    {
       
        float x = Random.Range(-4.0f, 4.0f);
        float z = Random.Range(-4.0f, 4.0f);

        target.transform.position = new Vector3(x, 0.0f, z);
        target.SetActive(true);



    }
}
