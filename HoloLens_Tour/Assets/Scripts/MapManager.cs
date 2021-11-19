using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapManager : MonoBehaviour
{
    //map cards
    public GameObject Instruction;
    public GameObject ZeroFloor;
    public GameObject FirstFloor;
    public GameObject SecondFloor;
    public GameObject ThirdFloor;

    //header text
    public GameObject InstructionText;
    public GameObject ZeroFloorText;
    public GameObject FirstFloorText;
    public GameObject SecondFloorText;
    public GameObject ThirdFloorText;

    //Asphalt on/off
    public GameObject AsphaltON;
    //Spot on/off
    public GameObject SpotON;
    //CERI on/off
    public GameObject CERI_ON;
    //Library on/off
    public GameObject LibraryON;
    //PEC on/off
    public GameObject PEC_ON;
    //VR on/off
    public GameObject VR_ON;
    //ThreeD on/off
    public GameObject ThreeD_ON;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ZeroFloor.activeInHierarchy)
        {
            //activate 0
            ZeroFloorText.SetActive(true);
            //turn off others
            InstructionText.SetActive(false);
            FirstFloorText.SetActive(false);
            SecondFloorText.SetActive(false);
            ThirdFloorText.SetActive(false);
        }
        if (FirstFloor.activeInHierarchy)
        {
            FirstFloorText.SetActive(true);
            //turn off others
            InstructionText.SetActive(false);
            ZeroFloorText.SetActive(false);
            SecondFloorText.SetActive(false);
            ThirdFloorText.SetActive(false);
        }
        if (SecondFloor.activeInHierarchy)
        {
            SecondFloorText.SetActive(true);
            //turn off others
            InstructionText.SetActive(false);
            ZeroFloorText.SetActive(false);
            FirstFloorText.SetActive(false);
            ThirdFloorText.SetActive(false);
        }
        if (ThirdFloor.activeInHierarchy)
        {
            ThirdFloorText.SetActive(true);
            //turn off others
            InstructionText.SetActive(false);
            ZeroFloorText.SetActive(false);
            FirstFloorText.SetActive(false);
            SecondFloorText.SetActive(false);
        }
        if (Instruction.activeInHierarchy)
        {
            InstructionText.SetActive(true);
            //turn off others
            ZeroFloorText.SetActive(false);
            FirstFloorText.SetActive(false);
            SecondFloorText.SetActive(false);
            ThirdFloorText.SetActive(false);
        }
    }
    public void AsphaltTabSelected()
    {
        //turn on the Select Icon
        AsphaltON.SetActive(true);
        //turn off the other select Icons
        SpotON.SetActive(false);
        CERI_ON.SetActive(false);
        LibraryON.SetActive(false);
        PEC_ON.SetActive(false);
        VR_ON.SetActive(false);
        ThreeD_ON.SetActive(false);
    }
    public void SpotTabSelected()
    {
        //turn on the Select Icon
        SpotON.SetActive(true);
        //turn off the other select Icons
        AsphaltON.SetActive(false);
        CERI_ON.SetActive(false);
        LibraryON.SetActive(false);
        PEC_ON.SetActive(false);
        VR_ON.SetActive(false);
        ThreeD_ON.SetActive(false);
    }
    public void CERITabSelected()
    {
        //turn on the Select Icon
        CERI_ON.SetActive(true);
        //turn off the other select Icons
        AsphaltON.SetActive(false);
        SpotON.SetActive(false);
        LibraryON.SetActive(false);
        PEC_ON.SetActive(false);
        VR_ON.SetActive(false);
        ThreeD_ON.SetActive(false);
    }
    public void LibraryTabSelected()
    {
        //turn on the Select Icon
        LibraryON.SetActive(true);
        //turn off the other select Icons
        AsphaltON.SetActive(false);
        CERI_ON.SetActive(false);
        SpotON.SetActive(false);
        PEC_ON.SetActive(false);
        VR_ON.SetActive(false);
        ThreeD_ON.SetActive(false);
    }
    public void PECTabSelected()
    {
        //turn on the Select Icon
        PEC_ON.SetActive(true);
        //turn off the other select Icons
        AsphaltON.SetActive(false);
        CERI_ON.SetActive(false);
        LibraryON.SetActive(false);
        SpotON.SetActive(false);
        VR_ON.SetActive(false);
        ThreeD_ON.SetActive(false);
    }
    public void VRTabSelected()
    {
        //turn on the Select Icon
        VR_ON.SetActive(true);
        //turn off the other select Icons
        AsphaltON.SetActive(false);
        CERI_ON.SetActive(false);
        LibraryON.SetActive(false);
        PEC_ON.SetActive(false);
        SpotON.SetActive(false);
        ThreeD_ON.SetActive(false);
    }
    public void ThreeDTabSelected()
    {
        //turn on the Select Icon
        ThreeD_ON.SetActive(true);
        //turn off the other select Icons
        AsphaltON.SetActive(false);
        CERI_ON.SetActive(false);
        LibraryON.SetActive(false);
        PEC_ON.SetActive(false);
        VR_ON.SetActive(false);
        SpotON.SetActive(false);
    }

    public void ResetMap()
    {
        //turn on instructions
        Instruction.SetActive(true);
        InstructionText.SetActive(true);
        //turn off all the select icons
        AsphaltON.SetActive(false);
        SpotON.SetActive(false);
        CERI_ON.SetActive(false);
        LibraryON.SetActive(false);
        PEC_ON.SetActive(false);
        VR_ON.SetActive(false);
        ThreeD_ON.SetActive(false);
        //turn off alll the cards
        ZeroFloor.SetActive(false);
        FirstFloor.SetActive(false);
        SecondFloor.SetActive(false);
        ThirdFloor.SetActive(false);

    }
}
