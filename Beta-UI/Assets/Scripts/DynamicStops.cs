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
    public AudioSource GeneralAudio1;
    public AudioSource GeneralAudio2;
    //News Cards
    public TextMeshProUGUI NewsBlurb;
    public TextMeshProUGUI NewsDetails;
    public AudioSource NewsAudio1;
    public AudioSource NewsAudio2;
    //Director Cards
    public TextMeshProUGUI DirBlurb;
    public TextMeshProUGUI DirDetails;
    public Image DirectorPhoto;
    public AudioSource DirectorAudio1;
    public AudioSource DirectorAudio2;
    //Faculty Cards
    public TextMeshProUGUI FacBlurb;
    public TextMeshProUGUI FacDetails;
    public AudioSource FacultyAudio1;
    public AudioSource FacultyAudio2;
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
    //audio clips 
    //asphalt lab clips
    //general audio
    public AudioClip Audio_Asphalt_G_Blurb;
    public AudioClip Audio_Asphalt_G_Details;
    //news audio 
    public AudioClip Audio_Asphalt_N_Blurb;
    public AudioClip Audio_Asphalt_N_Details;
    //director audio
    public AudioClip Audio_Asphalt_D_Blurb;
    public AudioClip Audio_Asphalt_D_Details;
    //faculty audio
    public AudioClip Audio_Asphalt_F_Blurb;
    public AudioClip Audio_Asphalt_F_Details;
    //Autonomous systems clips
    //general audio
    public AudioClip Audio_SPOT_G_Blurb;
    public AudioClip Audio_SPOT_G_Details;
    //news audio 
    public AudioClip Audio_SPOT_N_Blurb;
    public AudioClip Audio_SPOT_N_Details;
    //director audio
    public AudioClip Audio_SPOT_D_Blurb;
    public AudioClip Audio_SPOT_D_Details;
    //faculty audio
    public AudioClip Audio_SPOT_F_Blurb;
    public AudioClip Audio_SPOT_F_Details;
    //CERI clips
    //general audio
    public AudioClip Audio_CERI_G_Blurb;
    public AudioClip Audio_CERI_G_Details;
    //news audio 
    public AudioClip Audio_CERI_N_Blurb;
    public AudioClip Audio_CERI_N_Details;
    //director audio
    public AudioClip Audio_CERI_D_Blurb;
    public AudioClip Audio_CERI_D_Details;
    //faculty audio
    public AudioClip Audio_CERI_F_Blurb;
    public AudioClip Audio_CERI_F_Details;
    //VR Clips
    //general audio
    public AudioClip Audio_VR_G_Blurb;
    public AudioClip Audio_VR_G_Details;
    //news audio 
    public AudioClip Audio_VR_N_Blurb;
    public AudioClip Audio_VR_N_Details;
    //director audio
    public AudioClip Audio_VR_D_Blurb;
    public AudioClip Audio_VR_D_Details;
    //faculty audio
    public AudioClip Audio_VR_F_Blurb;
    public AudioClip Audio_VR_F_Details;
    //3D Printing Clips
    //general audio
    public AudioClip Audio_3D_G_Blurb;
    public AudioClip Audio_3D_G_Details;
    //news audio 
    public AudioClip Audio_3D_N_Blurb;
    public AudioClip Audio_3D_N_Details;
    //director audio
    public AudioClip Audio_3D_D_Blurb;
    public AudioClip Audio_3D_D_Details;
    //faculty audio
    public AudioClip Audio_3D_F_Blurb;
    public AudioClip Audio_3D_F_Details;

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
        string Asphalt_G_Detials = "A part of MU’s College of Engineering, the Mizzou Asphalt Pavement & Innovation Lab (MAPIL) is committed to cutting-edge asphalt research including mix design and surface sustainability. We specialize in finding advanced, intelligent structural materials design solutions for smart cities to make our communities more livable, sustainable, and safe. Through extensive research, education, creativity, and collaboration, MAPIL is continually developing innovative technologies to increase efficiencies across multiple disciplines, helping empower and improve communities throughout the world.";
        //news cards
        string Asphalt_N_Blurb = " In an effort to help keep this plastic waste from ending up in the environment,Engineers at the University of Missouri are partnering with Dow and the Missouri Department of Transportation (MoDOT) to test mixing plastic waste into the asphalt pavement mixtures.";
        string Asphalt_N_Detials = "Inside the Mizzou Asphalt Pavement and Innovation Lab, or MAPIL, located in the MU College of Engineering, engineers and students are determining how to incorporate various types of single-use, polyethylene-based plastic waste into asphalt pavement, including water bottles, grocery bags and drinking straws. Buttlar, the lab’s director, said the idea for using plastic waste in pavement developed through a series of conversations he had with Mizzou alumnus Jim Fitterling who is the chairman and CEO of Dow.";
        //director cards
        string Asphalt_D_Blurb ="Bill Buttlar is the Glen Barton Chair in Flexible Pavements in the Department of Civil and Environmental Engineering at the University of Missouri, where he oversees the Mizzou Asphalt Pavement and Innovation Lab(MAPIL).";
        string Asphalt_D_Detials = "Between 1996 and 2016, Buttlar served as professor of civil and environmental engineering at the University of Illinois at Urbana-Champaign. In his time there, he held the titles of Narbey Khachaturian Endowed Faculty Scholar and Associate Dean. He has over 300 publications in the area of asphalt materials and pavements and more than 80 invited presentations and keynote lectures. Buttlar is leading several regional and national studies on sustainable and resilient transportation infrastructure, including lab and field studies on post-consumer plastic and tire rubber recycling in asphalt pavements.";
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
        //assing audio
        GeneralAudio1.clip = Audio_Asphalt_G_Blurb;
        GeneralAudio2.clip = Audio_Asphalt_G_Details;
        //news cards
        NewsBlurb.text = Asphalt_N_Blurb;
        NewsDetails.text = Asphalt_N_Detials;
        //assing audio
        NewsAudio1.clip = Audio_Asphalt_N_Blurb;
        NewsAudio2.clip = Audio_Asphalt_N_Details;
        //director cards
        DirBlurb.text = Asphalt_D_Blurb;
        DirDetails.text = Asphalt_D_Detials;
        //director Photo
        DirectorPhoto.material = Asphalt_Director;
        //assing audio
        DirectorAudio1.clip = Audio_Asphalt_D_Blurb;
        DirectorAudio2.clip = Audio_Asphalt_D_Details;
        //facult cards
        FacBlurb.text = Asphalt_F_Blurb;
        FacDetails.text = Asphalt_F_Detials;
        //assing audio
        FacultyAudio1.clip = Audio_Asphalt_F_Blurb;
        FacultyAudio2.clip = Audio_Asphalt_F_Details;


    }
    private void SPOT()
    {
        //text to fill in 
        //title
        string SPOT_Title = "autonomous systems lab";
        //general cards
        string SPOT_G_Blurb = "The Autonomous System lab contains various user controlled systems such as SPOT. SPOT is an agile mobile robot made by Boston Dynamics.";
        string SPOT_G_Detials = "SPOT is the newest tech in the AS lab, where students explore working with autonomous technology. One of the examples Dale Musser taught is a script that forces a car to drive on the left side of the road and stay between the two lines. This is an example of an autonomous system because when the car starts moving it is programmed to stay between the two lines no matter what.";
        //news cards
        string SPOT_N_Blurb = "SPOT performed during the Marching Mizzou Half-time show. An IT student who is also in Marching Mizzou named Josh Boyer took on the project to have SPOT perform it’s dance.";
        string SPOT_N_Detials = "In June, a few months after SPOT came to campus, the autonomous systems lab began planning for its performance. To help announce the collaboration, Kristofferson Culmer brought SPOT to band camp and showed off some of his moves. When Josh came to Mizzou, the computer science major and Marching Mizzou member never thought he’d be controlling a robotic dog in a first-of-its-kind halftime show. SPOT’s main purpose is to provide a hands-on learning experience of how to program a robot and see your work come to life right in front of you";
        //director cards
        string SPOT_D_Blurb = "Kristofferson Culmer is an assistant professor of professional practice for the IT Program. Culmer teaches courses in software engineering such as programming languages and paradigms, database management systems and software engineering.";
        string SPOT_D_Detials = "Culmer is an advocate for higher education with a passion for service and has served the College of Engineering and the university in a number of ways. He has previously worked as a research mentor for the National Science Foundation (NSF), Research Experience for Undergraduates (REU) and also as a teaching lead for the STEM Cubs program, a STEM education outreach program for K-6 students in the local community. Culmer has also been involved in the Graduate Scholars of Excellence (GSE) program where he has served as a mentor for undergraduate students from underrepresented and underserved communities.";
        //faculty cards
        string SPOT_F_Blurb = "Kristofferson Culmer and Dale Musser are the two main faculty members overseeing the AS lab. Their vision for the future is to have students teaching students about autonomous systems.";
        string SPOT_F_Detials = "Christian Caldwell is graduating with a degree in computer science, working on drones that the AS lab has. Caldwell wanted to provide advanced features that students are able to implement. Caldwell has provided both original Tello codes and the commands he developed in a “Tello Playground” on GitHub. There, anyone can view and use the codes free of charge.";
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
        //assing audio
        //general
        GeneralAudio1.clip = Audio_SPOT_G_Blurb;
        GeneralAudio2.clip = Audio_Asphalt_G_Details;
        //news
        NewsAudio1.clip = Audio_SPOT_N_Blurb;
        NewsAudio2.clip = Audio_SPOT_N_Details;
        //director
        DirectorAudio1.clip = Audio_SPOT_D_Blurb;
        DirectorAudio2.clip = Audio_SPOT_D_Details;
        //faculty
        FacultyAudio1.clip = Audio_SPOT_F_Blurb;
        FacultyAudio2.clip = Audio_SPOT_F_Details;
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
        string CERI_N_Detials = "Cyber vision:A CAVE is a small facility that provides users with an immersive virtual environment. It consists of adjustable walls, a floor and motion sensors that track movement. Unlike other types of virtual reality, users do not have to wear bulky headsets to experience their 3D surroundings.";
        //director cards
        string CERI_D_Blurb = "Prasad Calyam is an associate professor in the Department of Electrical Engineering and Computer Science, director of the Mizzou CERI, and a core faculty member in the MU Institute for Data Science & Informatics.";
        string CERI_D_Detials = "His research and development areas of interest include distributed and cloud computing, computer networking, networked-multimedia applications and cyber security. He has published more than 145 papers in various conference and journal venues. As the principal investigator, he has successfully led teams of graduate, undergraduate and postdoctoral fellows in numerous federal-, state- and industry-sponsored research and development projects.";
        //faculty cards
        string CERI_F_Blurb = "Praveen Rao is an associate Professor at the University of Missouri who focuses on cyber infrastructure with CIRI. His research interests are in big data, data science, health informatics, and cybersecurity.";
        string CERI_F_Detials = "Praveen Rao  focuses on developing scalable algorithms and software systems to extract meaningful insights from massive, diverse datasets. His research, teaching, and outreach activities have been supported by the National Science Foundation (NSF), Air Force Research Lab (AFRL), the University of Missouri System, and University of Missouri Research Board.";
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
        //assing audio
        //general
        GeneralAudio1.clip = Audio_CERI_G_Blurb;
        GeneralAudio2.clip = Audio_CERI_G_Details;
        //news
        NewsAudio1.clip = Audio_CERI_N_Blurb;
        NewsAudio2.clip = Audio_CERI_N_Details;
        //director
        DirectorAudio1.clip = Audio_CERI_D_Blurb;
        DirectorAudio2.clip = Audio_CERI_D_Details;
        //faculty
        FacultyAudio1.clip = Audio_CERI_F_Blurb;
        FacultyAudio2.clip = Audio_CERI_F_Details;

    }
    private void VR()
    {
        //text to fill in 
        //title
        string VR_Title = "Virtual Reality lab";
        //general cards
        string VR_G_Blurb = "Mizzou’s Virtual Reality Lab is a state of the art laboratory with several computer workstations and VR play spaces for students to develop and explore virtual reality technology.";
        string VR_G_Detials = "The Collaborative Research Environments for Extended Reality also known as the CREXR Lab is a state of the art laboratory with several computer workstations and VR play spaces for students to develop and explore with virtual reality technology.";
        //news cards
        string VR_N_Blurb = "Mizzou Engineering students have created an interactive art exhibit that will allow visitors to view paintings without ever stepping inside a museum. The exhibit is being created digitally for a virtual reality (VR) experience.";
        string VR_N_Detials = "Students created various lighting effects for each piece. Charles Sielert, a recent IT graduate who is volunteering for the IT Program, took the lead on modeling the rooms, which also feature digital benches and elaborate flooring. The students also matched wall colors to the themes of the artwork; for instance, a room showcasing paintings of Missouri’s rivers is blue, while an agricultural-themed section is green.";
        //director cards
        string VR_D_Blurb = "Fang Wang is a professor in the IT Program at the University of Missouri. Fang is the director of the new Collaborative Research Environments for Extended Reality also known as CREXR, Lab.";
        string VR_D_Detials = "Fang Wang is a part of the Department of Electrical Engineering, Computer Science, and the IT Program at the University of Missouri. Before joining MU, she worked as a senior software engineer in research and development at Ansys Inc. Prior to that, she worked for six years as a senior device modeling and characterization engineer at Motorola Inc. and Freescale Semiconductor Inc. Her research interests include eldercare technology, image processing, gait analysis, passive monitoring, engineering simulation software development, semiconductor devices modeling and simulation.";
        //faculty cards
        string VR_F_Blurb = "Scottie Murrel is a Research Assistant at the University of Missouri who works in the CREXR lab alongside Fang Wang. ";
        string VR_F_Detials = "Scottie Murrel’s is a graduate student at the university of missouri whose interests include Unity, C#,Java, Information Technology, XR development and Spatial Computing. He has experience as a research professional as a Grad Student in Computer Science at the university of Missouri.";
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
        //assing audio
        //general
        GeneralAudio1.clip = Audio_VR_G_Blurb;
        GeneralAudio2.clip = Audio_VR_G_Details;
        //news
        NewsAudio1.clip = Audio_VR_N_Blurb;
        NewsAudio2.clip = Audio_VR_N_Details;
        //director
        DirectorAudio1.clip = Audio_VR_D_Blurb;
        DirectorAudio2.clip = Audio_VR_D_Details;
        //faculty
        FacultyAudio1.clip = Audio_VR_F_Blurb;
        FacultyAudio2.clip = Audio_VR_F_Details;

    }
    private void ThreeD()
    {
        //text to fill in 
        //title
        string ThreeD_Title = "3D printing lab";
        //general cards
        string ThreeD_G_Blurb = "Mizzou’s 3D Printing Research & Experience Lab aims to research and teach 3D printing concepts to any interested students. The lab also collaborates with businesses and industries around Missouri to provide them with 3D printing assistance and education.";
        string ThreeD_G_Detials = "Mizzou’s 3D Printing Research & Experience Lab aims to bring 3D printing access to all students and faculty. Any student may join the 3D printing club and create projects to print. The lab also collaborates with local businesses, printing out specialized parts and educating workers. There are research opportunities available to graduate students in the 3D printing lab. They experiment with cutting edge technologies and designs such as multi-material 3D printing, smart materials and machine learning for additive materials.";
        //news cards
        string ThreeD_N_Blurb = "Mizzou 3D printing provides services to others. One of the projects the 3D printing club took on was called, A Helping Hand, where they created prosthetic hands.";
        string ThreeD_N_Detials = "Mechanical engineering student Andrew Dove is the president of 3DPC and says the club spent the past year working on a low-budget prosthetic hand for people in India in collaboration with an Indian charity. John “J.D.” Peiffer, a junior majoring in bioengineering, says the doctors in India originally wanted a cosmetic hand for people who lost a hand due to amputation, but he says club members decided to make it functional.";
        //director cards
        string ThreeD_D_Blurb = "Oliver Giraldo-Londoño is the assistant Professor and James W. and Joan M. O’Neill Faculty Scholar in the Department of Civil & Environmental Engineering. Oliver is currently serving as the director of research for the 3D Printing Research & Experiences Lab.";
        string ThreeD_D_Detials = "Oliver Giraldo-Londoño is currently serving as the director of research for the 3D Printing Research & Experiences Lab. His research focuses on computational mechanics, particularly on the fields of topology optimization and computational fracture mechanics. His work has been published in the Proceedings of the Royal Society, Computer Methods in Applied Mechanics and Engineering, Structural and Multidisciplinary Optimization, among others.";
        //faculty cards
        string ThreeD_F_Blurb = "Oliver Giraldo-Londoño is the head faculty member over the 3D printing club. Andrew Dove is the president and oversees that prosthetic hand project.";
        string ThreeD_F_Detials = "Steven Devlin is the Associate Dean of Economic Development and Industrial Engagement as well as Director for Teaching and Service in Mizzou’s 3D Printing Lab. Andrew Dove is the lab president, along with Brady Hindersmann who is a senior majoring in civil engineering, John Peiffer a junior majoring in bioengineering, and Chris Scully their treasurer who is a dual CS IT major.";
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
        //assing audio
        //general
        GeneralAudio1.clip = Audio_3D_G_Blurb;
        GeneralAudio2.clip = Audio_3D_G_Details;
        //news
        NewsAudio1.clip = Audio_3D_N_Blurb;
        NewsAudio2.clip = Audio_3D_N_Details;
        //director
        DirectorAudio1.clip = Audio_3D_D_Blurb;
        DirectorAudio2.clip = Audio_3D_D_Details;
        //faculty
        FacultyAudio1.clip = Audio_3D_F_Blurb;
        FacultyAudio2.clip = Audio_3D_F_Details;

    }
}
