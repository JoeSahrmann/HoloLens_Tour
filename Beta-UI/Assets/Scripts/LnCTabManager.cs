using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LnCTabManager : MonoBehaviour
{    /// <summary>
     /// Cafe menu tabs
     /// </summary>
    //Cafe Menu
    public GameObject CafeMenu;
    //Hours Tab on / off objects
    public GameObject CafeHoursTabON;
    public GameObject CafeHoursTabOFF;
    //Hours Tab Cards
    public GameObject CHC1;
    public GameObject CHC2;
    //Menu Tab on / off objects
    public GameObject MenuTabON;
    public GameObject MenuTabOFF;
    //Menu Tab Cards
    public GameObject MC1;
    public GameObject MC2;
    //Order Tab on / off objects
    public GameObject OrderTabON;
    public GameObject OrderTabOFF;
    //Order Tab Cards
    public GameObject OC1;
    //public GameObject OC2;
    //Pay Tab on / off objects
    public GameObject PayTabON;
    public GameObject PayTabOFF;
    //Pay Tab Cards
    public GameObject PC1;
    //public GameObject PC2;
    //cafe instruction card
    public GameObject CafeInstructionCard;
    /// <summary>
    /// Library menu tabs
    /// </summary>
    //Library Menu
    public GameObject LibraryMenu;
    //Hours Tab on / off objects
    public GameObject LibraryHoursTabON;
    public GameObject LibraryHoursTabOFF;
    //Hours Tab Cards
    public GameObject LHC1;
    public GameObject LHC2;
    //services Tab on / off objects
    public GameObject ServiceTabON;
    public GameObject ServiceTabOFF;
    //Service Tab Cards
    public GameObject SC1;
    public GameObject SC2;
    //Equipment Tab on / off objects
    public GameObject EquipmentTabON;
    public GameObject EquipmentTabOFF;
    //Equipment Tab Cards
    public GameObject EC1;
    //public GameObject EC2;
    //Staff Tab on / off objects
    public GameObject StaffTabON;
    public GameObject StaffTabOFF;
    //staff Tab Cards
    public GameObject StaffC1;
    public GameObject StaffC2;
    //Library instruction card
    public GameObject LibraryInstructionCard;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StateChecker();
    }
    private void StateChecker()
    {
       
        if (CafeMenu.activeInHierarchy)
        {
            //hours tab Checker
            if (CafeHoursTabON.activeInHierarchy)
            {
                //make instruction card inactive
                CafeInstructionCard.SetActive(false);
                //make all other tabs off
                MenuTabON.SetActive(false);
                OrderTabON.SetActive(false);
                PayTabON.SetActive(false);
            }
            //Menu tab Checker
            if (MenuTabON.activeInHierarchy)
            {
                //make instruction card inactive
                CafeInstructionCard.SetActive(false);
                //make all other tabs off
                CafeHoursTabON.SetActive(false);
                OrderTabON.SetActive(false);
                PayTabON.SetActive(false);

            }
            //Order tab Checker
            if (OrderTabON.activeInHierarchy)
            {
                //make instruction card inactive
                CafeInstructionCard.SetActive(false);
                //make all other tabs off
                CafeHoursTabON.SetActive(false);
                MenuTabON.SetActive(false);
                PayTabON.SetActive(false);
            }
            //Pay tab Checker
            if (PayTabON.activeInHierarchy)
            {
                //make instruction card inactive
                CafeInstructionCard.SetActive(false);
                //make all other tabs off
                CafeHoursTabON.SetActive(false);
                MenuTabON.SetActive(false);
                OrderTabON.SetActive(false);
            }
        }
        if (LibraryMenu.activeInHierarchy)
        {
            //Hours tab Checker
            if (LibraryHoursTabON.activeInHierarchy)
            {
                //make instruction card inactive
                LibraryInstructionCard.SetActive(false);
                //make all other tabs off
                ServiceTabON.SetActive(false);
                EquipmentTabON.SetActive(false);
                StaffTabON.SetActive(false);
            }
            //Services tab Checker
            if (ServiceTabON.activeInHierarchy)
            {
                //make instruction card inactive
                LibraryInstructionCard.SetActive(false);
                //make all other tabs off
                LibraryHoursTabON.SetActive(false);
                EquipmentTabON.SetActive(false);
                StaffTabON.SetActive(false);

            }
            //Equipment tab Checker
            if (EquipmentTabON.activeInHierarchy)
            {
                //make instruction card inactive
                LibraryInstructionCard.SetActive(false);
                //make all other tabs off
                LibraryHoursTabON.SetActive(false);
                ServiceTabON.SetActive(false);
                StaffTabON.SetActive(false);
            }
            //staff tab Checker
            if (StaffTabON.activeInHierarchy)
            {
                //make instruction card inactive
                LibraryInstructionCard.SetActive(false);
                //make all other tabs off
                LibraryHoursTabON.SetActive(false);
                ServiceTabON.SetActive(false);
                EquipmentTabON.SetActive(false);
            }
        }
    }
    /// <summary>
    /// Cafe Menu Tabs
    /// </summary>
    public void CafeHoursTabSelected()
    {
        //if hit again reset to have the header card display first
        CHC1.SetActive(true);
        CHC2.SetActive(false);
        //make instruction card inactive
        CafeInstructionCard.SetActive(false);
        CafeHoursTabON.SetActive(true);
        //turn others off the on
        MenuTabON.SetActive(false);
        OrderTabON.SetActive(false);
        PayTabON.SetActive(false);
        //turn on the off
        MenuTabOFF.SetActive(true);
        OrderTabOFF.SetActive(true);
        PayTabOFF.SetActive(true);

        StateChecker();
    }
    public void MenuTabSelected()
    {
        //if hit again reset to have the header card display first
        MC1.SetActive(true);
        MC2.SetActive(false);
        //make instruction card inactive
        CafeInstructionCard.SetActive(false);
        MenuTabON.SetActive(true);
        //turn others off the on 
        CafeHoursTabON.SetActive(false);
        OrderTabON.SetActive(false);
        PayTabON.SetActive(false);
        //turn on the off
        CafeHoursTabOFF.SetActive(true);
        OrderTabOFF.SetActive(true);
        PayTabOFF.SetActive(true);

        StateChecker();
    }
    public void OrderTabSelected()
    {
        //if hit again reset to have the header card display first
        OC1.SetActive(true);
        //make instruction card inactive
        CafeInstructionCard.SetActive(false);
        OrderTabON.SetActive(true);
        //turn others off the on 
        CafeHoursTabON.SetActive(false);
        MenuTabON.SetActive(false);
        PayTabON.SetActive(false);
        //turn on the off
        CafeHoursTabOFF.SetActive(true);
        MenuTabOFF.SetActive(true);
        PayTabOFF.SetActive(true);

        StateChecker();
    }
    public void PayTabSelected()
    {
        //if hit again reset to have the header card display first
        PC1.SetActive(true);
        //make instruction card inactive
        CafeInstructionCard.SetActive(false);
        PayTabON.SetActive(true);
        //turn others off the on 
        CafeHoursTabON.SetActive(false);
        MenuTabON.SetActive(false);
        OrderTabON.SetActive(false);
        //turn on the off
        CafeHoursTabOFF.SetActive(true);
        MenuTabOFF.SetActive(true);
        OrderTabOFF.SetActive(true);

        StateChecker();
    }
    /// <summary>
    /// Libary Menu Tabs
    /// </summary>
    public void LibraryHoursTabSelected()
    {
        //if hit again reset to have the header card display first
        LHC1.SetActive(true);
        LHC2.SetActive(false);
        //make instruction card inactive
        LibraryInstructionCard.SetActive(false);
        LibraryHoursTabON.SetActive(true);
        //turn others off the on
        ServiceTabON.SetActive(false);
        EquipmentTabON.SetActive(false);
        StaffTabON.SetActive(false);
        //turn on the off
        ServiceTabOFF.SetActive(true);
        EquipmentTabOFF.SetActive(true);
        StaffTabOFF.SetActive(true);

        StateChecker();
    }
    public void ServiceTabSelected()
    {
        //if hit again reset to have the header card display first
        SC1.SetActive(true);
        SC2.SetActive(false);
        //make instruction card inactive
        LibraryInstructionCard.SetActive(false);
        ServiceTabON.SetActive(true);
        //turn others off the on 
        LibraryHoursTabON.SetActive(false);
        EquipmentTabON.SetActive(false);
        StaffTabON.SetActive(false);
        //turn on the off
        LibraryHoursTabOFF.SetActive(true);
        EquipmentTabOFF.SetActive(true);
        StaffTabOFF.SetActive(true);

        StateChecker();
    }
    public void EquipmentTabSelected()
    {
        //if hit again reset to have the header card display first
        EC1.SetActive(true);
        //make instruction card inactive
        LibraryInstructionCard.SetActive(false);
        EquipmentTabON.SetActive(true);
        //turn others off the on 
        LibraryHoursTabON.SetActive(false);
        ServiceTabON.SetActive(false);
        StaffTabON.SetActive(false);
        //turn on the off
        LibraryHoursTabOFF.SetActive(true);
        ServiceTabOFF.SetActive(true);
        StaffTabOFF.SetActive(true);

        StateChecker();
    }
    public void StaffTabSelected()
    {
        //if hit again reset to have the header card display first
        StaffC1.SetActive(true);
        StaffC2.SetActive(false);
        //make instruction card inactive
        LibraryInstructionCard.SetActive(false);
        StaffTabON.SetActive(true);
        //turn others off the on 
        LibraryHoursTabON.SetActive(false);
        ServiceTabON.SetActive(false);
        EquipmentTabON.SetActive(false);
        //turn on the off
        LibraryHoursTabOFF.SetActive(true);
        ServiceTabOFF.SetActive(true);
        EquipmentTabOFF.SetActive(true);

        StateChecker();
    }
    /// <summary>
    /// reset all of the tabs 
    /// </summary>
    public void ResetTabs()
    {
      
        if (CafeMenu.activeInHierarchy)
        {
            //turn on instructions
            CafeInstructionCard.SetActive(true);
            //turn off the icons
            CafeHoursTabON.SetActive(false);
            MenuTabON.SetActive(false);
            OrderTabON.SetActive(false);
            PayTabON.SetActive(false);
            //reset the cards
            CHC1.SetActive(false);
            CHC2.SetActive(false);
            MC1.SetActive(false);
            MC2.SetActive(false);
            OC1.SetActive(false);
            PC1.SetActive(false);

        }
        if (LibraryMenu.activeInHierarchy)
        {
            //turn on instructions
            LibraryInstructionCard.SetActive(true);
            //turn off the icons
            LibraryHoursTabON.SetActive(false);
            ServiceTabON.SetActive(false);
            EquipmentTabON.SetActive(false);
            StaffTabON.SetActive(false);
            //reset the cards
            LHC1.SetActive(false);
            LHC2.SetActive(false);
            SC1.SetActive(false);
            SC2.SetActive(false);
            EC1.SetActive(false);
            StaffC1.SetActive(false);
            StaffC2.SetActive(false);
        }


    }
}
