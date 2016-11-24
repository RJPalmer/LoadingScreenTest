using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mainTitleBtnsScript : MonoBehaviour
{

    bool optIsClicked;
    bool exitOptnsMenu;
    public Animator animator;
	
    // Use this for initialization
	void Start () {
        optIsClicked = false;
        exitOptnsMenu = false;
    	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Enter options: " + optIsClicked);
        //Debug.Log("Exit Options: " + exitOptnsMenu);
	}

    //Close the application when exitBtn is clicked
   public void exitButton()
    {
        Debug.Log("Exiting Application");
        //Quit is ignored in the editor. IMPORTANT: In most cases termination of application under iOS should be left at the user discretion. 
       //Consult Apple Technical Page qa1561 for further details.
        Application.Quit();
    }

    //Bring up the options menu when clicked
   public void optionsButton()
   {
       Debug.Log("Enter options: " + optIsClicked);
       if (optIsClicked)
           optIsClicked = false;
       if (optIsClicked.Equals(false))
       {
           optIsClicked = true;
           exitOptnsMenu = false;

           animator.SetBool("optIsClicked", optIsClicked);
           animator.SetBool("exitOptnsMenu", exitOptnsMenu);
           if (transform.parent.parent.gameObject.transform.Find("optionsPanel") != null)
           {
               Debug.Log("optionsPanel found");
               transform.parent.parent.gameObject.transform.Find("optionsPanel").gameObject.SetActive(true);
           }
           else
           {
               Debug.Log("optionsPanel not found");
           }
       }
   }

    //exit the options menu when 'Go Back' button is pressed
   public void exitOptions()
   {
       Debug.Log("Enter options: " + optIsClicked);
       optIsClicked = false;
       if (exitOptnsMenu)
           exitOptnsMenu = false;
       if (exitOptnsMenu.Equals(false))
       {
           exitOptnsMenu = true;
           optIsClicked = false;
           
           //update the AnimationController
           animator.SetBool("optIsClicked", optIsClicked);
           animator.SetBool("exitOptnsMenu", exitOptnsMenu);
           this.transform.parent.gameObject.SetActive(false);
       }
   }
}
