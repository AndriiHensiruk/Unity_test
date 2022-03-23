using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blok4_task4 : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject[] objToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            spawnPoint = Instantiate(objToSpawn[0]);
            spawnPoint.transform.position = new Vector3(1, 4+i, -10);
        }
        // for(int i=0; i<4; i++)
        //Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {  
        
        
        
    }
}
