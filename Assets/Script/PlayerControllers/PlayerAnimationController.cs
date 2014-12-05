using UnityEngine;
using System.Collections;
using System.Reflection;

public enum DirectionOfAnimation
{
    Left,
    Right
}

public class PlayerAnimationController : MonoBehaviour {


    bool isSliding = false;
    bool isJumping = false;

    public Animator animatorController;

    public void Strafe(DirectionOfAnimation direction)
    {
        switch (direction)
        {
            case DirectionOfAnimation.Left:
                animatorController.SetBool("isStrafingLeft", true);
                StartCoroutine(StopCurrentAnimation("isStrafingLeft", 0.3f));
                break;
            case DirectionOfAnimation.Right:
                animatorController.SetBool("isStrafingRight", true);
                StartCoroutine(StopCurrentAnimation("isStrafingRight", 0.3f));
                break;
        }
    }

    public void Jump()
    {
            isJumping = true;
            animatorController.SetBool("isJumping", isJumping);
            StartCoroutine(StopCurrentAnimation("isJumping", 1f));
    }

    public void WaterAnimation(bool isWaterAnimation)
    {
        animatorController.SetBool("isWater", isWaterAnimation);
    }

    public void Fall(bool isFalling)
    {
        animatorController.SetBool("isFalling", isFalling);
    }

    public void WallWalk(DirectionOfAnimation direction, bool isStarted)
    {
        switch (direction)
        {
            case DirectionOfAnimation.Left:
                animatorController.SetBool("isWallLeft", isStarted);
                break;
            case DirectionOfAnimation.Right:
                animatorController.SetBool("isWallRight", isStarted);
                break;
        }
    }

    public void Slide()
    {
        if (!isSliding)
        {
            isSliding = true;
            animatorController.SetBool("isSliding", isSliding);
            StartCoroutine(StopCurrentAnimation("isSliding", 0.3f));
            isSliding = false;
        }
    }

    IEnumerator StopCurrentAnimation(string animationBooleanName, float forSeconds)
    {
        yield return new WaitForSeconds(forSeconds);
        animatorController.SetBool(animationBooleanName, false);
        if (animationBooleanName == "isJumping")
            isJumping = false;
    }

    public void Sprint()
    {
        animatorController.SetBool("isSprinting", true);
    }

    public void StopSprint()
    {
        animatorController.SetBool("isSprinting", false);
    }

}
