using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DynamicStops : MonoBehaviour
{
    private string Portal = ManageScenes.PortalEntered;
    //the different menus
    //labs
    public GameObject LabMenu;
    //library
    public GameObject LibraryMenu;
    //Cafe
    public GameObject CafeMenu;

    //All of the text that needs to be updated
    //title of Lab
    public TextMeshProUGUI Title;
    //General Cards
    public TextMeshProUGUI GeneralBlurb;
    public TextMeshProUGUI GeneralDetails;
    public Image GeneralHeaderPhoto;
    //News Cards
    public TextMeshProUGUI NewsBlurb;
    public TextMeshProUGUI NewsDetails;
    //Director Cards
    public TextMeshProUGUI DirBlurb;
    public TextMeshProUGUI DirDetails;
    public Image DirectorPhoto;
    //Faculty Cards
    public TextMeshProUGUI FacBlurb;
    public TextMeshProUGUI FacDetails;
    //all header materials
    public Material Asphalt_Header;
    public Material CERI_Header;
    public Material SPOT_Header;
    public Material VR_Header;
    public Material ThreeD_Header;
    //all director materials
    public Material Asphalt_Director;
    public Material CERI_Director;
    public Material SPOT_Director;
    public Material VR_Director;
    public Material ThreeD_Director;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WhatMenu();
        UpdateLabMenu();
    }
    //check to see what button was selected and turn on respective menu
    private void WhatMenu()
    {
        if (Portal == "library")
        {
            //turn off others
            LabMenu.SetActive(false);
            CafeMenu.SetActive(false);
            //turn on Library Menu
            LibraryMenu.SetActive(true);
        }
        if (Portal == "pec")
        {
            //turn off others
            LabMenu.SetActive(false);
            LibraryMenu.SetActive(false);
            //turn on Library Menu
            CafeMenu.SetActive(true);
        }
        if (Portal != "library" && Portal != "pec")
        {
            //turn off others
            LibraryMenu.SetActive(false);
            CafeMenu.SetActive(false);
            //turn on Library Menu
            LabMenu.SetActive(true);

        }
    }
    //populate the lab menu with the correct text
    public void UpdateLabMenu()
    {
         if(Portal == "asphalt")
         {
            Asphalt();
         }
         if (Portal == "spot")
         {
            SPOT(); 
         }
         if (Portal == "ceri")
         {
            CERI();
         }
         if (Portal == "vr")
         {
            VR();
         }
         if (Portal == "3d")
         {
            ThreeD();
         }

    }
    //update the text for each of the labs
    private void Asphalt()
    {
        //text to fill in 
        //title
        string Asphalt_Title = "mizzou asphalt & inovation lab";
        //general cards
        string Asphalt_G_Blurb = "Mizzou Asphalt Pavement & Innovation Lab (MAPIL) specializes in finding advanced, intelligent structural materials design solutions for smart cities to make our communities more livable, sustainable, and safe.";
        string Asphalt_G_Detials = "A part of MU’s College of Engineering, the Mizzou Asphalt Pavement & Innovation Lab (MAPIL) is committed to cutting-edge asphalt research, mix design and surface sustainability. We specialize in finding advanced, intelligent structural materials design solutions for smart cities to make our communities more livable, sustainable, and safe. Through extensive research, education, creativity, and collaboration, MAPIL is continually developing innovative technologies to increase efficiencies across multiple disciplines, helping empower and improve communities throughout the world.";
        //news cards
        string Asphalt_N_Blurb = "In an effort to help keep this waste from ending up in the environment,Engineers at the University of Missouri are partnering with Dow and the Missouri Department of Transportation (MoDOT) to test mixing plastic waste into the asphalt pavement mixtures.";
        string Asphalt_N_Detials = "Inside the Mizzou Asphalt Pavement and Innovation Lab, or MAPIL, located in the MU College of Engineering, engineers and students are determining how to incorporate various types of single-use, polyethylene-based plastic waste into asphalt pavement, including drinking bottles, grocery bags and drinking straws. Buttlar, the lab’s director, said the idea for using plastic waste in pavement developed through a series of conversations he had with Mizzou alumnus Jim Fitterling who is the chairman and CEO of Dow.";
        //director cards
        string Asphalt_D_Blurb = "Bill Buttlar is the Glen Barton Chair in Flexible Pavements in the Department of Civil and Environmental Engineering at the University of Missouri, where he oversees the Mizzou Asphalt Pavement and Innovation Lab (MAPIL)";
        string Asphalt_D_Detials = "Between 1996 and 2016, Buttlar served as professor of civil and environmental engineering at the University of Illinois at Urbana-Champaign and held the title of Narbey Khachaturian Endowed Faculty Scholar and Associate Dean. He has more than 300 publications in the area of asphalt materials and pavements and more than 80 invited presentations and keynote lectures. He is leading several regional and national studies on sustainable and resilient transportation infrastructure, including lab and field studies on post-consumer plastic and tire rubber recycling in asphalt pavements.";
        //faculty cards
        string Asphalt_F_Blurb = "James Meister and Henry C. Brown are currently assisting Bill Buttlar with the Mizzou Asphalt Pavement and Innovations Lab. Select Read more to learn about the faculty.";
        string Asphalt_F_Detials = "James Meister is responsible for purchase and installation of the testing equipment in MAPIL. As well as, training all student researchers on proper equipment usage and applicable test standards while conducting field visits for asphalt sampling.\nHenry C. Brown is responsible for asset management for local governments, development of a work zone safety assessment tool, calibration of Highway Safety Manual, evaluating work zone sign configurations, evaluating J-turn intersection designs, and data collection for bicycle treatment evaluation.";
        //now assing them to the TMPGUI text on the cards
        //Header Photo
        GeneralHeaderPhoto.material = Asphalt_Header;
        //title
        Title.text = Asphalt_Title;
        //general cards
        GeneralBlurb.text = Asphalt_G_Blurb;
        GeneralDetails.text = Asphalt_G_Detials;
        //news cards
        NewsBlurb.text = Asphalt_N_Blurb;
        NewsDetails.text = Asphalt_N_Detials;
        //director cards
        DirBlurb.text = Asphalt_D_Blurb;
        DirDetails.text = Asphalt_D_Detials;
        //director Photo
        DirectorPhoto.material = Asphalt_Director;
        //facult cards
        FacBlurb.text = Asphalt_F_Blurb;
        FacDetails.text = Asphalt_F_Detials;

    }
    private void SPOT()
    {
        //text to fill in 
        //title
        string SPOT_Title = "autonomous systems lab";
        //general cards
        string SPOT_G_Blurb = "";
        string SPOT_G_Detials = "";
        //news cards
        string SPOT_N_Blurb = "";
        string SPOT_N_Detials = "";
        //director cards
        string SPOT_D_Blurb = "";
        string SPOT_D_Detials = "";
        //faculty cards
        string SPOT_F_Blurb = "";
        string SPOT_F_Detials = "";
        //now assing them to the TMPGUI text on the cards
        //Header Photo
        GeneralHeaderPhoto.material = SPOT_Header;
        //title
        Title.text = SPOT_Title;
        //general cards
        GeneralBlurb.text = SPOT_G_Blurb;
        GeneralDetails.text = SPOT_G_Detials;
        //news cards
        NewsBlurb.text = SPOT_N_Blurb;
        NewsDetails.text = SPOT_N_Detials;
        //director cards
        DirBlurb.text = SPOT_D_Blurb;
        DirDetails.text = SPOT_D_Detials;
        //director Photo
        DirectorPhoto.material = SPOT_Director;
        //facult cards
        FacBlurb.text = SPOT_F_Blurb;
        FacDetails.text = SPOT_F_Detials;

    }
    private void CERI()
    {
        //text to fill in 
        //title
        string CERI_Title = "Cyber Education Research & Infrastructure";
        //general cards
        string CERI_G_Blurb = "CERI is a multi-disciplinary center formed to foster information technology innovations in areas of Cyber, Artificial Intelligence and Big Data Analytics to meet the needs of the nation in information security and cyber defense.";
        string CERI_G_Detials = "CERI Center was formed in 2019 with support from a highly competitive 2019 UM System Tier 1 grant, guided by an existing seed investment (serving as a cost-share commitment for the proposed project duration) of “Cyber Education and Research Initiative” at the MU College of Engineering. The CERI Center builds on research strengths, and a survey of cyber needs across the UM System/peer universities, and funding priorities of industry/federal agencies.";
        //news cards
        string CERI_N_Blurb = "The CERI lab studies cyber security areas including: infrastructure, vision, intelligence, and training. Their research has led to many newsworthy breakthroughs over the last three years in each of their focus areas.";
        string CERI_N_Detials = "Cyber vision:A CAVE is a small facility that provides users with an immersive virtual environment. It consists of adjustable walls, a floor and motion sensors that track movement. Unlike other types of virtual reality, users do not have to wear bulky headsets to experience their 3D surroundings.\nCyber intelligence: A team of Mizzou Engineers is turning to artificial intelligence (AI) to help grow and control large quantities of carbon nanotubes—tiny, cylinder-shaped molecules made of rolled sheets of carbon.";
        //director cards
        string CERI_D_Blurb = "Prasad Calyam is an associate professor in the Department of Electrical Engineering and Computer Science, director of the Mizzou CERI, and a core faculty member in the MU Institute for Data Science & Informatics.";
        string CERI_D_Detials = " His research and development areas of interest include distributed and cloud computing, computer networking, networked-multimedia applications and cyber security. He has published more than 145 papers in various conference and journal venues. As the principal investigator, he has successfully led teams of graduate, undergraduate and postdoctoral fellows in numerous federal-, state- and industry-sponsored research and development projects.";
        //faculty cards
        string CERI_F_Blurb = "";
        string CERI_F_Detials = "";
        //now assing them to the TMPGUI text on the cards
        //Header Photo
        GeneralHeaderPhoto.material = CERI_Header;
        //title
        Title.text = CERI_Title;
        //general cards
        GeneralBlurb.text = CERI_G_Blurb;
        GeneralDetails.text = CERI_G_Detials;
        //news cards
        NewsBlurb.text = CERI_N_Blurb;
        NewsDetails.text = CERI_N_Detials;
        //director cards
        DirBlurb.text = CERI_D_Blurb;
        DirDetails.text = CERI_D_Detials;
        //director Photo
        DirectorPhoto.material = CERI_Director;
        //facult cards
        FacBlurb.text = CERI_F_Blurb;
        FacDetails.text = CERI_F_Detials;

    }
    private void VR()
    {
        //text to fill in 
        //title
        string VR_Title = "Virtual Reality lab";
        //general cards
        string VR_G_Blurb = "Mizzou’s Virtual Reality Lab is a state of the art laboratory with several computer workstations and VR play spaces for students to develop and explore virtual reality technology.";
        string VR_G_Detials = "";
        //news cards
        string VR_N_Blurb = "Mizzou Engineering students have created an interactive art exhibit that will allow visitors to view paintings without ever stepping inside a museum. The exhibit is being created digitally for a virtual reality (VR) experience.";
        string VR_N_Detials = "Students created various lighting effects for each piece. Charles Sielert, a recent IT graduate who is volunteering for the IT Program, took the lead on modeling the rooms, which also feature digital benches and elaborate flooring. The students also matched wall colors to the themes of the artwork; for instance, a room showcasing paintings of Missouri’s rivers is blue, while an agricultural-themed section is green.";
        //director cards
        string VR_D_Blurb = "Fang Wang is a professor in the IT Program at the University of Missouri. Wang has worked as a senior software engineer in research and development at Ansys Inc. and Motorola Inc.";
        string VR_D_Detials = "";
        //faculty cards
        string VR_F_Blurb = "";
        string VR_F_Detials = "";
        //now assing them to the TMPGUI text on the cards
        //Header Photo
        GeneralHeaderPhoto.material = VR_Header;
        //title
        Title.text = VR_Title;
        //general cards
        GeneralBlurb.text = VR_G_Blurb;
        GeneralDetails.text = VR_G_Detials;
        //news cards
        NewsBlurb.text = VR_N_Blurb;
        NewsDetails.text = VR_N_Detials;
        //director cards
        DirBlurb.text = VR_D_Blurb;
        DirDetails.text = VR_D_Detials;
        //director Photo
        DirectorPhoto.material = VR_Director;
        //facult cards
        FacBlurb.text = VR_F_Blurb;
        FacDetails.text = VR_F_Detials;

    }
    private void ThreeD()
    {
        //text to fill in 
        //title
        string ThreeD_Title = "3D printing lab";
        //general cards
        string ThreeD_G_Blurb = "";
        string ThreeD_G_Detials = "";
        //news cards
        string ThreeD_N_Blurb = "";
        string ThreeD_N_Detials = "";
        //director cards
        string ThreeD_D_Blurb = "";
        string ThreeD_D_Detials = "";
        //faculty cards
        string ThreeD_F_Blurb = "";
        string ThreeD_F_Detials = "";
        //now assing them to the TMPGUI text on the cards
        //Header Photo
        GeneralHeaderPhoto.material = ThreeD_Header;
        //title
        Title.text = ThreeD_Title;
        //general cards
        GeneralBlurb.text = ThreeD_G_Blurb;
        GeneralDetails.text = ThreeD_G_Detials;
        //news cards
        NewsBlurb.text = ThreeD_N_Blurb;
        NewsDetails.text = ThreeD_N_Detials;
        //director cards
        DirBlurb.text = ThreeD_D_Blurb;
        DirDetails.text = ThreeD_D_Detials;
        //director Photo
        DirectorPhoto.material = ThreeD_Director;
        //facult cards
        FacBlurb.text = ThreeD_F_Blurb;
        FacDetails.text = ThreeD_F_Detials;

    }
}
