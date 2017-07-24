using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class PlayerAnimationController : MonoBehaviour
{
    #region Attributes

    private Animator animator;

    private const string IDLE_ANIMATION_BOOL = "idle";
    private const string DEATH_ANIMATION_BOOL = "die";
    private const string ATTACK_ANIMATION_BOOL = "attack";
    private const string MOVE_ANIMATION_BOOL = "move";

    #endregion

    #region Monobehaviour API

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    #endregion

    #region Animate Functions

    public void AnimateIdle()
    {
        Animate(IDLE_ANIMATION_BOOL);
    }

    public void AnimateDeath()
    {
        Animate(DEATH_ANIMATION_BOOL);
    }

    public void AnimateAttack()
    {
        Animate(ATTACK_ANIMATION_BOOL);
    }

    public void AnimateMove()
    {
        Animate(MOVE_ANIMATION_BOOL);
    }

    #endregion

    #region Helpers

    private void Animate(string boolName)
    {
        DisableOtherAnimations(animator, boolName);
        animator.SetBool(boolName, true);
    }

    private void DisableOtherAnimations(Animator animator, string animation)
    {
        foreach (AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parameter.name != animation)
            {
                animator.SetBool(parameter.name, false);
            }
        }
    }

    #endregion
}
