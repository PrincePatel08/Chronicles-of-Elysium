using StarterAssets;
using UnityEngine;

public class PlayerBusy : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<ThirdPersonController>().IsBusy = true;
    }
}
