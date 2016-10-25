using UnityEngine;
using System.Collections;

public class CarDestroy : MonoBehaviour {

    private Camera _mainCamera;


    // Use this for initialization
    void Start () {

        GameObject CAMERA = GameObject.Find("Main Camera");
        _mainCamera = CAMERA.GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        GameObject cars = GameObject.FindGameObjectWithTag("CarTag");
        

        
        if (_mainCamera.transform.position.z> cars.transform.position.z)
        {
            Object.Destroy(cars);
        }
        
        

       


    }
}
