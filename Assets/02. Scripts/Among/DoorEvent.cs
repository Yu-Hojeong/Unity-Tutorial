using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collision)
    {
        animator.SetTrigger("Open");
    }
    void OnCollisionExit(Collision collision)
    {
        animator.SetTrigger("Close");
    }
}
