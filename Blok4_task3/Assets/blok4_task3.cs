using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok4_task3 : MonoBehaviour
{
   

    public int a, b;

    private Vector3 startPosition;
    private Vector3 endPosition;

    private float step=0.005f;
    private float progres;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(0, 2, -10);
        transform.position = startPosition; 
      

       
    }

    // Update is called once per frame
    void Update()
    {
        endPosition = new Vector3(0, -(a+b), -10);
        transform.position = Vector3.Lerp(startPosition, endPosition, progres);
        progres += step;
    }
}
