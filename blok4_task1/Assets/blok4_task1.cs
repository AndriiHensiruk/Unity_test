using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok4_task1 : MonoBehaviour
{
    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objects[0], objects[0].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
