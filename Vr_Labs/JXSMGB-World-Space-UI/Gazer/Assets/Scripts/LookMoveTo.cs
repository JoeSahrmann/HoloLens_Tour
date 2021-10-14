using UnityEngine;
using System.Collections;

public class LookMoveTo : MonoBehaviour {

    public GameObject ground;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Transform camera = Camera.main.transform;
        Ray ray;
        // RaycastHit hit;
        RaycastHit[] hits; 
        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward*100.0f, Color.red, 1, true);
       //Physics.Raycast(Vector3 orgin, )
        ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        hits = Physics.RaycastAll(ray, Mathf.Infinity, 5);
        for (int i =0; i<hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            hitObject = hit.collider.gameObject;

            if (hitObject == ground)
            {
                Debug.Log("Hit (x,y,z): " + hit.point.ToString("F2"));
                transform.position = hit.point;
            }
        }

        // extra challenge - Layer mask, see
        //http://stackoverflow.com/questions/24563085/raycast-but-ignore-yourself

        //see P73, only hit ground
        //if (Physics .Raycast(ray, out hit))
        //{
        //    hitObject = hit.collider.gameObject;

        //    if (hitObject == ground)
        //    {
        //        Debug.Log("Hit (x,y,z): " + hit.point.ToString("F2"));
        //        transform.position = hit.point;
        //    }
        //}

    }
}
