using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public PlayerAnimationController animationController;
    public PlayerPositionController positionController;
    public GameObject Ragdoll;
    public GameObject Constructor;

    public RoadMoveScript road;

    bool isFalling = false;
    bool isStartFalling = false;

    float timeForStartFalling = 0;

    public void Slide()
    {
        if (!isFalling)
            animationController.Slide();
    }

    public void Jump()
    {
        if (!isFalling)
        {
            isFalling = true;
            positionController.Jump();
            animationController.Jump();
        }
    }

    public void Water(bool isWater)
    {
        animationController.WaterAnimation(isWater);
    }

    public void Strafe(DirectionOfAnimation direction)
    {
        animationController.Strafe(direction);
        positionController.Strafe(direction);
    }

    public void WallWalkStart(DirectionOfAnimation direction)
    {
        animationController.WallWalk(direction, true);
    }

    public void WallWalkStop(DirectionOfAnimation direction)
    {
        animationController.WallWalk(direction, false);
    }

    public void Sprint(bool isStart)
    {
        if (isStart)
        {
            animationController.Sprint();
            road.IncreaseSpeed(2);
        }
        else
        {
            animationController.StopSprint();
            road.NormolizeSpeed();
        }
    }

    void StartRagdoll()
    {
        Ragdoll.active = true;
        Constructor.active = false;
        GetComponent<BoxCollider>().enabled = false;
        road.Stop();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponents<ObstacleMoveScript>().Length > 0)
        {
            road.Stop();
            StartRagdoll();
        }
        isFalling = false;
        animationController.Fall(false);
        timeForStartFalling = 0;
        isStartFalling = false;
    }

    void OnCollisionExit(Collision collision)
    {
        isStartFalling = true;
    }

    void Update()
    {
        if (isFalling)
        {
            animationController.Fall(true);
        }

        if (isStartFalling)
        {
            timeForStartFalling += Time.deltaTime;
            if (timeForStartFalling > 2)
            {
                isFalling = true;
            }
        }
    }
}
