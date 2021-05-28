using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCol : MonoBehaviour
{
    // Start is called before the first frame update
    public ulong score = 0;
    public GameObject snake;
    public GameObject feverActiv;
    private bool flagFevet = false;
    

    void Start()
    {
        
    }

    private void FeverActiv()
    {
        feverActiv.SetActive(true);
        MoveObject.speed = MoveObject.speed * 3;
        flagFevet = true;
        Invoke("DeActive", 5);

    }
    private void DeActive()
    {
        feverActiv.SetActive(false);
        MoveObject.speed = MoveObject.speed / 3;
        flagFevet = false;
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (flagFevet)
        {
            if (collision.gameObject.tag != "wall")
            {
                Destroy(collision.gameObject);
                score++;
            }
            
        }else if (collision.gameObject.tag == "death")
        {
            Application.LoadLevel(0);

        }else if (snake.GetComponent<SkinnedMeshRenderer>().materials[0].color == 
            collision.gameObject.GetComponent<MeshRenderer>().materials[0].color)
        {
            Destroy(collision.gameObject);
            score++;
        }
        else
        {
            Application.LoadLevel(0);

        }
        if (!flagFevet)
        {
            if (score % 10 == 0 && score != 0)
            {
                Invoke("FeverActiv", 0);
            }

        }
       
        
        //Debug.Log("dsfdsf");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "colorch")
        {
            snake.GetComponent<SkinnedMeshRenderer>().materials[0].color 
                = other.gameObject.GetComponent<MeshRenderer>().materials[0].color;
        }
    }

}
