using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCControl : MonoBehaviour
{
    // Start is called before the first frame update

    public float board = 1.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v=new Vector3();
        if (Application.platform == RuntimePlatform.Android)
            v = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
       else if (Application.platform == RuntimePlatform.WindowsEditor)
            v = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        else if (Application.platform == RuntimePlatform.WindowsPlayer)
            v = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 g = transform.position;
        g.x = v.x;
        if (g.x < -board) g.x = -board; 
        if (g.x > board) g.x = board; 
        transform.position = g;


        
    }
}
