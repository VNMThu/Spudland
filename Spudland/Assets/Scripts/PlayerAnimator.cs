using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator: MonoBehaviour
{
    //References
    Animator animator;
    PlayerMovement playerMovement;
    SpriteRenderer spriteRenderer;

    
    void Start()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (playerMovement.moveDir.x != 0 || playerMovement.moveDir.y != 0)
        {
            animator.SetBool("New Bool", true);

            SpriteDirectionChecker();
        }
        else
        {
            animator.SetBool("New Bool", false);
        }
    }

    void SpriteDirectionChecker()
    {
        if (playerMovement.lastHorizontalVector < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
