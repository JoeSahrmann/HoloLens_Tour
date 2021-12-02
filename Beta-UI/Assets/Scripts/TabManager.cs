using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    /// <summary>
    /// Lab Menu tabs
    /// </summary>
    //Lab Menu
    public GameObject LabMenu;
    //General Tab on / off objects
    public GameObject GeneralTabON;
    public GameObject GeneralTabOFF;
    //General Tab Cards
    public GameObject GC1;
    public GameObject GC2; 
    //News Tab on / off objects
    public GameObject NewsTabON;
    public GameObject NewsTabOFF;
    //News Tab Cards
    public GameObject NC1;
    public GameObject NC2;
    //Director Tab on / off objects
    public GameObject DirectorTabON;
    public GameObject DirectorTabOFF;
    //Director Tab Cards
    public GameObject DC1;
    public GameObject DC2;
    //Faculty Tab on / off objects
    public GameObject FacultyTabON;
    public GameObject FacultyTabOFF;
    //Faculty Tab Cards
    public GameObject FC1;
    public GameObject FC2;
    //instruction card
    public GameObject LabInstructionCard;


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
    /// <summary>
    /// Lab Menu Tabs
    /// </summary>
    private void StateChecker()
    {
          //general tab Checker
                if (GeneralTabON.activeInHierarchy)
                {
                    //make instruction card inactive
                    LabInstructionCard.SetActive(false);
                    //make all other tabs off
                    NewsTabON.SetActive(false);
                    DirectorTabON.SetActive(false);
                    FacultyTabON.SetActive(false);
                }
                //news tab Checker
                if (NewsTabON.activeInHierarchy)
                {
                    //make instruction card inactive
                    LabInstructionCard.SetActive(false);
                    //make all other tabs off
                    GeneralTabON.SetActive(false);
                    DirectorTabON.SetActive(false);
                    FacultyTabON.SetActive(false);

                }
                //director tab Checker
                if (DirectorTabON.activeInHierarchy)
                {
                    //make instruction card inactive
                    LabInstructionCard.SetActive(false);
                    //make all other tabs off
                    GeneralTabON.SetActive(false);
                    NewsTabON.SetActive(false);
                    FacultyTabON.SetActive(false);
                }
                //faculty tab Checker
                if (FacultyTabON.activeInHierarchy)
                {
                    //make instruction card inactive
                    LabInstructionCard.SetActive(false);
                    //make all other tabs off
                    GeneralTabON.SetActive(false);
                    NewsTabON.SetActive(false);
                    DirectorTabON.SetActive(false);
     
        }

    }
    public void GeneralTabSelected()
    {
        //if hit again reset to have the header card display first
        GC1.SetActive(true);
        GC2.SetActive(false);
        //make instruction card inactive
        LabInstructionCard.SetActive(false);
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
        LabInstructionCard.SetActive(false);
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
        LabInstructionCard.SetActive(false);
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
        LabInstructionCard.SetActive(false);
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

    /// <summary>
    /// reset all of the tabs 
    /// </summary>
    public void ResetTabs()
    {

                //turn on instructions
                LabInstructionCard.SetActive(true);
                //turn off the icons
                GeneralTabON.SetActive(false);
                NewsTabON.SetActive(false);
                DirectorTabON.SetActive(false);
                FacultyTabON.SetActive(false);
                //reset the cards
                GC1.SetActive(false);
                GC2.SetActive(false);
                NC1.SetActive(false);
                NC2.SetActive(false);
                DC1.SetActive(false);
                DC2.SetActive(false);
                FC1.SetActive(false);
                FC2.SetActive(false);


    }
}
