using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] spawnObjects;
    public float board = 5;
    public float boardTimeStart = 1; 
    public float boardTimeEnd = 5; 
    void Start()
    {
        Invoke("Spawn", Random.Range(boardTimeStart, boardTimeEnd));
    }

    private void Spawn()
    {

        if (gameObject.activeSelf)
        {
            int randindex = Random.Range(0, spawnObjects.Length);
            GameObject g = Instantiate(spawnObjects[randindex]);

            Vector3 v = transform.position;
            v.x = Random.Range(-board, board);
            g.transform.position = v;
        }
        Invoke("Spawn", Random.Range(boardTimeStart, boardTimeEnd));
        
    }


    // Update is called once per frame

}
