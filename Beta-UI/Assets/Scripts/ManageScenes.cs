using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ManageScenes : MonoBehaviour
{
    public TextMeshProUGUI ModeText;
    public GameObject ExitModeON;
    public GameObject ExitModeOFF;
    private string SceneName;

    //pass what scene was choosen
    public static string PortalEntered;

    //all assets for discovery scene
   // public TextMeshProUGUI StopTitleText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SceneName = SceneManager.GetActiveScene().name;
        ModeText.text = SceneName.ToLower();
        SceneChecker();
        //UpdateDiscovery();
    }
    private void SceneChecker()
    {
        if(SceneName == "Tutorial" | SceneName == "Discovery")
        {
            ExitModeON.SetActive(true);
            ExitModeOFF.SetActive(false);
        }
        if (SceneName == "Welcome" | SceneName == "Explorer")
        {
            ExitModeON.SetActive(false);
            ExitModeOFF.SetActive(true);
        }

    }
    public void Exit_T_D()
    {
        SceneManager.LoadScene("Explorer");
    }
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
       
    }
    public void EnterPortal(string PortalClicked)
    {
        PortalEntered = PortalClicked;

    }

}
