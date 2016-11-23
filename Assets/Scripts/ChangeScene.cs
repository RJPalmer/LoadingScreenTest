using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public int Counter;
    [HideInInspector] bool isLogged;
    public Animator animColorFade;
    public AnimationClip fadeColorAnimationClip;
    
    
	// Use this for initialization
	void Start () {
        Counter = 0;
        isLogged = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        Counter++;

              
            if(!isLogged)
                Debug.Log("Trigger Loading Screen Fade");
            isLogged = true;
            animColorFade.SetInteger("Counter", Counter);

            
            
   
	}

    void HideDelayed()
    {
        
    }
}
