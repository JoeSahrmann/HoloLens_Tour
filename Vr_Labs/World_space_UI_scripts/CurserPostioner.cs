using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurserPostioner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cursor;
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.transform.rotation * Vector3.forward * 5f);//this sends out a ray into the world
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && (hit.collider.gameObject == target))//This states if the ray cast hits the target
        {
            float distance = hit.distance * .9f;
            cursor.transform.localPosition = new Vector3(0, 0, distance);
          //  Debug.Log(hit.distance);
            // cursor.transform.localScale.x * hit.distance;
            float scaleDistance = hit.distance * .00135f;
          float scaleX = scaleDistance;
            float scaleY = scaleDistance;
            float scaleZ = scaleDistance;
            Debug.Log(scaleZ);
            cursor.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
            //x * hit.distance
            //y * hit.distance
            //z * hit.distance
        }
        else
        {
            cursor.transform.localScale = new Vector3(0.00135f, 0.00135f, 0.00135f);
            cursor.transform.localPosition = new Vector3(0.0f, 0.0f, 1.0f);
        }

    }
}
