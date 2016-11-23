using UnityEngine;
using System.Collections;

public class exitButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Close the application when exitBtn is clicked
   public void exitButton()
    {
        Debug.Log("Exiting Application");
        //Quit is ignored in the editor. IMPORTANT: In most cases termination of application under iOS should be left at the user discretion. 
       //Consult Apple Technical Page qa1561 for further details.
        Application.Quit();
    }
}
