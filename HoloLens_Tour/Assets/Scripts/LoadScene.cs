using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private string PortalEntered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PortalEntered == "BetaUI")
        {
            Debug.Log("Yay");
        }
        else
        {
            Debug.Log(PortalEntered);
        }
    }
   public void SceneLoader(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        PortalEntered = SceneName;
    }
}
