using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawnerScript : MonoBehaviour
{
    public GameObject floor1;
    public GameObject floor2;

    public float spawnRate = 7.8f;
    private float timer = 0;
    private int floorDecide = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            floorDecideSpawn(floorDecide);
            floorDecide++;
            //Instantiate(floor1, transform.position, transform.rotation);
            timer = 0;
        }

        
    }

    void floorDecideSpawn(int num)
    {
        if(num%5==0)
        {
            spawnFloor(floor1);
        }
        else
        {
            spawnFloor(floor2);
        }
    }

    void spawnFloor(GameObject obj)
    {
        Instantiate(obj, transform.position, transform.rotation);
    }
}
