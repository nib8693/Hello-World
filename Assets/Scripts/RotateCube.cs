using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{

    public GameObject cube;
    private GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(0, 3, 0);

        cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach(GameObject singlecube in cubes)
        {
            singlecube.transform.Rotate(3, 0, 0);
        }
    }
}
