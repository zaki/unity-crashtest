using UnityEngine;

public class Test : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        AnimatorOverrideController controller = new AnimatorOverrideController();

        animator.runtimeAnimatorController = controller;
    }
}
