using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public GameObject InfoBoard;
    public GameObject PromptMessage;
    //change text objects on panels
    public Text NameTMP;
    public Text PurposeTMP;
    public Text HistoryTMP;
    public Text ResearchTMP;
    public Text EquipmentTMP;
    public Text CapabilitiesTMP;
    public Text DirectorTMP;
    public Text FacultyTMP;
    // Smooth transition in for cube
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public Transform startMarker;
    public Transform endMarker;
    private int StartClicked = 0;
    private float timer = 0.0f;
    private float waitTime = 1.0f;
    private Animator anim;
    //create arrays to populate text
    private string[] NameRAY = { "Mizzou Asphalt Pavement and Innovation Laboratory (MAPIL)" };
    public string[] PurposeRAY = { "A part of MU’s College of Engineering, the Mizzou Asphalt Pavement & Innovation Lab (MAPIL) is committed to cutting-edge asphalt research, mix design and surface sustainability. We specialize in finding advanced, intelligent structural materials design solutions for smart cities to make our communities more livable, sustainable, and safe. Through extensive research, education, creativity, and collaboration, MAPIL is continually developing innovative technologies to increase efficiencies across multiple disciplines, helping empower and improve communities throughout the world." };
    public string[] HistoryRAY = { "MAPIL was established in 2016 with Dr. Bill Buttlar, the Glen Barton Endowed Faculty Chair in Flexible Pavement Systems, as its Director. Located near historic Jesse Hall in the heart of the University of Missouri campus, MAPIL is a home to some of the most advanced thinkers in the asphalt industry." };
    public string[] ResearchRAY = { "We use state-of-the-art lab tests, equipment, and ever-evolving technologies (including artificial intelligence and machine learning), to design products and publish discoveries related to asphalt materials, flexible and composite pavements, and smart transportation infrastructure." };
    public string[] EquipmentRAY = { "We have a range of material characterization machines that serve different purposes, starting from a Universal Testing Machine that can apply up to 20,000 pounds of force in a variety of loading waveforms to a specialized low-temperature performance characterization machine that applies specific loadings to specific types of samples. We also have an advanced rheology characterization machine that can apply precision loads and measure responses of a drop of asphalt binder at temperatures ranging from 200C to -40C.  We even have a portable, near infrared spectrometer that works with a smartphone to quickly finger print the chemical composition of asphalt and many other substances." };
    public string[] CapabilitiesRAY = { "We have advanced characterization machines that can handle a wide range of material properties, testing temperatures, loading patterns and levels. In addition, we continually develop in-house specialized characterization tests to study behavior of novel materials.  We specialize in sustainable, recycled materials, such as the optimized use of recycled waste plastic and recycled tire rubber in asphalt.  Our machine learning algorithms greatly reduce the time and cost of evaluating infrastructure materials and in-place pavement condition, while improving accuracy and presenting the results on an interactive, cloud-based visualization platform." };
    public string[] DirectorRAY = { "Dr. Bill Buttlar" };
    public string[] FacultyRAY = { "Dr. Bill Buttlar" };
    //number of stops
    private int numbeofStops = 2;
    
    void Start()
    {
        anim = InfoBoard.gameObject.GetComponent<Animator>();
        PromptMessage.SetActive(true);
        InfoBoard.SetActive(false);

        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);

        //gen all the data into the arrays
          NameTMP.text = NameRAY[0];
          PurposeTMP.text = PurposeRAY[0];
          HistoryTMP.text = HistoryRAY[0];
          ResearchTMP.text = ResearchRAY[0];
          EquipmentTMP.text = EquipmentRAY[0];
          CapabilitiesTMP.text = CapabilitiesRAY[0];
          DirectorTMP.text = DirectorRAY[0];
          FacultyTMP.text = FacultyRAY[0];


}
   public void TaskOnClick()
    {
        StartClicked = 1;
        PromptMessage.SetActive(false);
        InfoBoard.SetActive(true);

    }
    void Update()
    {
        ZoomCube();
    }
    private void ZoomCube()
    {

       
        switch (StartClicked)
        {
            case 1:
                timer += Time.deltaTime;

                if (timer > waitTime)
                {
                    // Remove the recorded 1 seconds.
                    timer = timer - waitTime;
                    StartClicked = 0;
                    anim.speed = 0;
                }
                else
                {
                    anim.Play("ZoomAni");
                    anim.speed = 1;
                    // Smooth transition in for cube
                    /*float distCovered = (Time.time - startTime) * speed;
                    float fractionOfJourney = distCovered / journeyLength;
                    InfoBoard.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
                */
                    }
                break;
          
            default:
                anim.speed = 0;
                break;
        }
    }
}
