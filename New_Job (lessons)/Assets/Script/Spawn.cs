using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject cloud;

    private void Start()
    {
        SpawnCloud();
    }

    void SpawnCloud()
    {
        Instantiate(cloud, transform.position, Quaternion.identity);
        Invoke("SpawnCloud", 5F);
    }
}
