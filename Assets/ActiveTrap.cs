using UnityEngine;

public class ActiveTrap : MonoBehaviour
{
    public string trapObjectName = "trap";
    public string trap2ObjectName = "trap2";

    private void OnTriggerEnter(Collider other)
    {
        GameObject trapObject = GameObject.Find(trapObjectName);
        if (trapObject != null)
        {
            Animator trapAnimator = trapObject.GetComponent<Animator>();
            if (trapAnimator != null)
            {
                trapAnimator.SetBool("Active", true);
            }
        }

        GameObject trap2Object = GameObject.Find(trap2ObjectName);
        if (trap2Object != null)
        {
            Animator trap2Animator = trap2Object.GetComponent<Animator>();
            if (trap2Animator != null)
            {
                trap2Animator.SetBool("Active", true);
            }
        }
    }
}
