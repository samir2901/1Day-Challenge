using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] objectsToBeThrown;
    int index;
    public float minX, maxX;
    public float start, everySec;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", start, everySec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObject()
    {
        index = Random.Range(0, objectsToBeThrown.Length);
        Instantiate(objectsToBeThrown[index], generateRandomPos(), Quaternion.identity);
    }

    Vector2 generateRandomPos()
    {
        float posX = Random.Range(minX, maxX);
        Vector2 spawnPos = new Vector2(posX, transform.position.y);
        return spawnPos;
    }
}
