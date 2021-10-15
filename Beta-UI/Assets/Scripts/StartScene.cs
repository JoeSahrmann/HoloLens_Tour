using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public GameObject InfoBoard;
    public GameObject PromptMessage;
    //public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        PromptMessage.SetActive(true);
        InfoBoard.SetActive(false);
      //  Button btn = startButton.GetComponent<Button>();
       // btn.onClick.AddListener(TaskOnClick);
    }
   public void TaskOnClick()
    {
        PromptMessage.SetActive(false);
        InfoBoard.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
