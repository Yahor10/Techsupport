using UnityEngine;
using System.Collections;

public class PlayersKeyController : MonoBehaviour {

    public PlayerController playerController;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Application.LoadLevel(0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerController.Slide();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerController.Jump();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerController.Strafe(DirectionOfAnimation.Right);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerController.Strafe(DirectionOfAnimation.Left);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerController.WallWalkStart(DirectionOfAnimation.Left);
        }
        else
        if (Input.GetKeyUp(KeyCode.Q))
        {
            playerController.WallWalkStop(DirectionOfAnimation.Left);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            playerController.WallWalkStart(DirectionOfAnimation.Right);
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            playerController.WallWalkStop(DirectionOfAnimation.Right);
        }
           

        if (Input.GetKey(KeyCode.Z))
        {
            playerController.Water(true);
        }
        else playerController.Water(false);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerController.Sprint(true);
        }
        else playerController.Sprint(false);
    }
}
