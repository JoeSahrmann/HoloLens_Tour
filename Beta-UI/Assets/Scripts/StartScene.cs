using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public GameObject InfoBoard;
    public GameObject PromptMessage;
    public Transform startMarker;
    public Transform endMarker;
    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;
    //public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        PromptMessage.SetActive(true);
        InfoBoard.SetActive(false);
        //  Button btn = startButton.GetComponent<Button>();
        // btn.onClick.AddListener(TaskOnClick);
        // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
   public void TaskOnClick()
    {
        PromptMessage.SetActive(false);
        InfoBoard.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        InfoBoard.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);


    }
}
