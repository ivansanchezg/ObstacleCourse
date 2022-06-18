using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFallingObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    [SerializeField]
    private float minTime = 3f;
    [SerializeField]
    private float maxTime = 5f;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    private float currentTimeWait;
    private float timeCounter;

    void Start()
    {
        currentTimeWait = Random.Range(minTime, maxTime);
        timeCounter = 0f;
    }

    void Update()
    {
        timeCounter += Time.deltaTime;

        if (timeCounter >= currentTimeWait)
        {
            timeCounter = 0f;
            Vector3 position = GenerateRandomPosition();
            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }
    }

    private Vector3 GenerateRandomPosition()
    {
        float x = Random.Range(minX, maxX);
        float z = Random.Range(minZ, maxZ);
        return new Vector3(x, 10f, z);
    }
}
