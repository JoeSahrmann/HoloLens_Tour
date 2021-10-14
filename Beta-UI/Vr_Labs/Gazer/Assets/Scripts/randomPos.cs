using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomPos : MonoBehaviour
{
    public int sec = 50;
    public Text bubbletxt;
    public GameObject Target;
    public GameObject Canvas;
    public Transform Camera;
    // Start is called before the first frame update
    void Start()
    {
        bubbletxt.text = "X:00.00; Z:00.00";
        StartCoroutine(rePosition());
    }
    IEnumerator rePosition()
    {
        while (true)
        {
            setradom();
            yield return new WaitForSeconds(5);
        }
    }

    void setradom()
    {
        float x = Random.Range(-4.0f, 4.0f);
        float z = Random.Range(-4.0f, 4.0f);
        transform.position = new Vector3(x, 0.0f, z);
        //bubbletxt.text = "X: " + x + "; Z: " + z;
    }

    // Update is called once per frame
    void Update()
    {
        Canvas.transform.LookAt(Camera);
        float x = Target.transform.position.x;
        float z = Target.transform.position.z;
        bubbletxt.text = "X:" + x + "; Z:" + z;
    }
}
