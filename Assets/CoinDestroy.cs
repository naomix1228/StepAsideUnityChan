using UnityEngine;
using System.Collections;

public class CoinDestroy : MonoBehaviour {

    private Camera _mainCamera;


    // Use this for initialization
    void Start () {

        GameObject CAMERA = GameObject.Find("Main Camera");
        _mainCamera = CAMERA.GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        GameObject coins = GameObject.FindGameObjectWithTag("CoinTag");
        

        
        if (_mainCamera.transform.position.z> coins.transform.position.z)
        {
            Object.Destroy(coins);
        }
        
        

       


    }
}
