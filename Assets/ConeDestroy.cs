using UnityEngine;
using System.Collections;

public class ConeDestroy : MonoBehaviour {

    private Camera _mainCamera;


    // Use this for initialization
    void Start () {

        GameObject CAMERA = GameObject.Find("Main Camera");
        _mainCamera = CAMERA.GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        GameObject cones = GameObject.FindGameObjectWithTag("TrafficConeTag");
        

        
        if (_mainCamera.transform.position.z> cones.transform.position.z)
        {
            Object.Destroy(cones);
        }
        
        

       


    }
}
