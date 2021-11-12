using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    //General Tab on / off objects
    public GameObject GeneralTabON;
    public GameObject GeneralTabOFF;
    //General Tab Cards
   // public GameObject GeneralCards;
    public GameObject GC1;
    public GameObject GC2; 
    //News Tab on / off objects
    public GameObject NewsTabON;
    public GameObject NewsTabOFF;
    //News Tab Cards
    //public GameObject NewsCards;
    public GameObject NC1;
    public GameObject NC2;
    //Director Tab on / off objects
    public GameObject DirectorTabON;
    public GameObject DirectorTabOFF;
    //Director Tab Cards
   // public GameObject DirectorCards;
    public GameObject DC1;
    public GameObject DC2;
    //Faculty Tab on / off objects
    public GameObject FacultyTabON;
    public GameObject FacultyTabOFF;
    //Faculty Tab Cards
   // public GameObject FacultyCards;
    public GameObject FC1;
    public GameObject FC2;
    //instruction card
    public GameObject InstructionCard;


    // Start is called before the first frame update
    void Start()
    {
        StateChecker();
    }

    // Update is called once per frame
    void Update()
    {
        StateChecker();
    }
    private void StateChecker()
    {
        //general tab Checker
        /*if (GeneralTabOFF.activeInHierarchy)
        {
            GeneralCards.SetActive(false);
        }*/
        if (GeneralTabON.activeInHierarchy)
        {
            //make instruction card inactive
            InstructionCard.SetActive(false);
            //make all other tabs off
            NewsTabON.SetActive(false);
            DirectorTabON.SetActive(false);
            FacultyTabON.SetActive(false);
            //turn on General cards
          //  GeneralCards.SetActive(true);
        }
        //news tab Checker
        /*
        if (NewsTabOFF.activeInHierarchy)
        {
            NewsCards.SetActive(false);
        }*/
        if (NewsTabON.activeInHierarchy)
        {
            //make instruction card inactive
            InstructionCard.SetActive(false);
            //make all other tabs off
            GeneralTabON.SetActive(false);
            DirectorTabON.SetActive(false);
            FacultyTabON.SetActive(false);
            //turn on news cards
            //NewsCards.SetActive(true);
        }
        //director tab Checker
        /*if (DirectorTabOFF.activeInHierarchy)
        {
            DirectorCards.SetActive(false);
        }*/
        if (DirectorTabON.activeInHierarchy)
        {
            //make instruction card inactive
            InstructionCard.SetActive(false);
            //make all other tabs off
            GeneralTabON.SetActive(false);
            NewsTabON.SetActive(false);
            FacultyTabON.SetActive(false);
            //turn on director cards
           // DirectorCards.SetActive(true);
        }
        //faculty tab Checker
        /*if (FacultyTabOFF.activeInHierarchy)
        {
            FacultyCards.SetActive(false);
        }*/
        if (FacultyTabON.activeInHierarchy)
        {
            //make instruction card inactive
            InstructionCard.SetActive(false);
            //make all other tabs off
            GeneralTabON.SetActive(false);
            NewsTabON.SetActive(false);
            DirectorTabON.SetActive(false);
            //turn on faculty cards
            //FacultyCards.SetActive(true);
        }
    }
    public void GeneralTabSelected()
    {
        //if hit again reset to have the header card display first
        GC1.SetActive(true);
        GC2.SetActive(false);
        //make instruction card inactive
        InstructionCard.SetActive(false);
        GeneralTabON.SetActive(true);
        //turn others off the on
        NewsTabON.SetActive(false);
        DirectorTabON.SetActive(false);
        FacultyTabON.SetActive(false);
        //turn on the off
        NewsTabOFF.SetActive(true);
        DirectorTabOFF.SetActive(true);
        FacultyTabOFF.SetActive(true);

        StateChecker();
    }
    public void NewsTabSelected()
    {
        //if hit again reset to have the header card display first
        NC1.SetActive(true);
        NC2.SetActive(false);
        //make instruction card inactive
        InstructionCard.SetActive(false);
        NewsTabON.SetActive(true);
        //turn others off the on 
        GeneralTabON.SetActive(false);
        DirectorTabON.SetActive(false);
        FacultyTabON.SetActive(false);
        //turn on the off
        GeneralTabOFF.SetActive(true);
        DirectorTabOFF.SetActive(true);
        FacultyTabOFF.SetActive(true);

        StateChecker();
    }
    public void DirectorTabSelected()
    {
        //if hit again reset to have the header card display first
        DC1.SetActive(true);
        DC2.SetActive(false);
        //make instruction card inactive
        InstructionCard.SetActive(false);
        DirectorTabON.SetActive(true);
        //turn others off the on 
        GeneralTabON.SetActive(false);
        NewsTabON.SetActive(false);
        FacultyTabON.SetActive(false);
        //turn on the off
        GeneralTabOFF.SetActive(true);
        NewsTabOFF.SetActive(true);
        FacultyTabOFF.SetActive(true);

        StateChecker();
    }
    public void FacultyTabSelected()
    {
        //if hit again reset to have the header card display first
        FC1.SetActive(true);
        FC2.SetActive(false);
        //make instruction card inactive
        InstructionCard.SetActive(false);
        FacultyTabON.SetActive(true);
        //turn others off the on 
        GeneralTabON.SetActive(false);
        NewsTabON.SetActive(false);
        DirectorTabON.SetActive(false);
        //turn on the off
        GeneralTabOFF.SetActive(true);
        NewsTabOFF.SetActive(true);
        DirectorTabOFF.SetActive(true);

        StateChecker();
    }
}
