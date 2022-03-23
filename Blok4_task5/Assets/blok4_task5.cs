using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok4_task5 : MonoBehaviour
{
    private GameObject gameCub1, gameCub2, gameCub3;
    public GameObject[] objToSpawn;

    public Vector3 firstVector, secondVector;
    private Vector3 sumaVector;

   // public int x, y, z, x1, y1, z1;
    // Start is called before the first frame update
    void Start()
    {
        gameCub1 = Instantiate(objToSpawn[0]);
        gameCub2 = Instantiate(objToSpawn[0]);
        gameCub3 = Instantiate(objToSpawn[0]);
    }

    // Update is called once per frame
    void Update()
    {
        sumaVector = secondVector + firstVector;

        gameCub1.transform.position = firstVector;
        gameCub2.transform.position = secondVector;
        gameCub3.transform.position = sumaVector;
    }
}
