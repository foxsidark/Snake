using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCControlSnake : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform direction;
    public GameObject[] snakeBones;
  
    private float baseForMove = 0.1f ;

    void Start()
    {
       

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float d = direction.position.x;
        float m = (d - snakeBones[0].transform.position.x);

        m = (d - snakeBones[0].transform.position.x);
        var v = snakeBones[0].transform.position;
        v.x = m / (baseForMove);
        snakeBones[0].GetComponent<Rigidbody>().velocity = v;
        for (int i = 1; i < snakeBones.Length; i++) {
            m = (snakeBones[i-1].transform.position.x - snakeBones[i].transform.position.x);
            v = snakeBones[i].transform.position;
            v.x = m / (baseForMove);
            snakeBones[i].GetComponent<Rigidbody>().velocity = v;
        }
        
        
       
    }
}
