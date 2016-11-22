﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NewTestScript : StateMachineBehaviour {

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SceneManager.LoadScene("testanimation2");
    }

     //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //Debug.Log("State Info normalized time: " + stateInfo.normalizedTime);
        //if(stateInfo.normalizedTime > 0.6729562 && stateInfo.normalizedTime < 0.68){
        //    //animator.Stop();
        //    SceneManager.LoadScene("testanimation2");
        //    //animator.Play("LoadTitleScreenState", layerIndex, stateInfo.normalizedTime);
        //}
	}

     //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //SceneManager.LoadScene("testanimation2");
        
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}