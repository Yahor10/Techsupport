using UnityEngine;
using System.Collections;

public class RoadMoveScript : MonoBehaviour
{
    public float currentSpeed;
    public float speed;

    public float totalLength = 300;

    public float blockLength = 25;

    private float z;

    private float lastZ;

    void Update()
    {
        Vector3 currentPosition = transform.position;
        transform.position = new Vector3(currentPosition.x, currentPosition.y, transform.position.z - currentSpeed * Time.deltaTime);
        z += transform.position.z - lastZ;
        lastZ = transform.position.z;
        if (z < -(totalLength + blockLength))
        {
            Vector3 updatedPosition = transform.position;
            updatedPosition.z = -totalLength;
            transform.position = updatedPosition;
        }
    }

    public void IncreaseSpeed(float multiplier)
    {
        currentSpeed = speed * multiplier;
    }

    public void NormolizeSpeed()
    {
        currentSpeed = speed;
    }

    public void DecreaseSpeed(float divisor)
    {
        currentSpeed = speed / divisor;
    }

    public void Stop()
    {
        this.enabled = false;
    }
}