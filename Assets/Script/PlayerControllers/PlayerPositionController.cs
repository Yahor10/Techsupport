using UnityEngine;
using System.Collections;

public class PlayerPositionController : MonoBehaviour
{

    bool isStrafing;

    Vector3 nextPosition;

    public float strafePower;

    public float jumpPower;

    void Start()
    {
        nextPosition = transform.localPosition;
    }

    public void Strafe(DirectionOfAnimation direction)
    {
        if (!isStrafing)
        {
            isStrafing = true;
            switch (direction)
            {
                case DirectionOfAnimation.Left:
                    rigidbody.AddForce(new Vector3(-strafePower * 1.5f, strafePower / 2, 0), ForceMode.Impulse);
                    break;
                case DirectionOfAnimation.Right:
                    rigidbody.AddForce(new Vector3(strafePower * 1.5f, strafePower / 2, 0), ForceMode.Impulse);
                    break;
            }
            isStrafing = false;
        }
    }

    public void Jump()
    {
        rigidbody.AddForce(new Vector3(0, jumpPower, 0), ForceMode.VelocityChange);
    }
}
