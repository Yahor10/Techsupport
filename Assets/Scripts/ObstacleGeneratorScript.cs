using UnityEngine;
using System.Collections;

public class ObstacleGeneratorScript : MonoBehaviour
{

    public Transform barrelPrefab;

    public Transform boxPrefab;

    public float[] positions = new float[] { -10, 0, 10 };

    private double timePassed = 0;

    void Start()
    {

    }

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 1)
        {
            Transform obstacle;
            if (Random.Range(0, 2) == 0)
            {
                obstacle = Instantiate(barrelPrefab) as Transform;
            }
            else
            {
                obstacle = Instantiate(boxPrefab) as Transform;
            }
            obstacle.position = new Vector3(positions[Random.Range(0, 3)], 10, 600);
            timePassed = 0;
        }
    }
}