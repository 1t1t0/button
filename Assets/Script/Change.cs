using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0)) {
		    SceneManager.LoadScene("FB0.0cm");
	    }
	    if(Input.GetKeyDown(KeyCode.Alpha4)) {
		   SceneManager.LoadScene("FB4.0cm");
	    }      
    }
}
