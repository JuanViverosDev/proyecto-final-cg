using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isJumpingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isJumping = animator.GetBool(isJumpingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool jumpPressed = Input.GetKey("space");

        if (forwardPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }
        else if (!forwardPressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (runPressed && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }
        else if (!runPressed && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
        if (jumpPressed && !isJumping)
        {
            animator.SetBool(isJumpingHash, true);
        }
        else if (!jumpPressed && isJumping)
        {
            animator.SetBool(isJumpingHash, false);
        }
    }
}
