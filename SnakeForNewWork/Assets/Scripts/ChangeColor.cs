using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnObj;
    public GameObject chcolorObj;
    [SerializeField]
    private Material[] materials;
    public float period = 40;
    private int previndex = 0;

    void Start()
    {
        MoveObject.speed = 7;
        Invoke("chcolor", period);
    }

    // Update is called once per frame
    private void chcolor()
    {
        
        
        spawnObj.SetActive(false);
        Invoke("activeSpawnOnj", 3);
        Invoke("chcolor", period);
        Invoke("helpSpawn", 1);       
    }
    private void helpSpawn()
    {
        int index = Random.Range(0, materials.Length);
        while(index == previndex)
        {
            index = Random.Range(0, materials.Length);
        }
        previndex = index;
        GameObject g = Instantiate(chcolorObj);
        g.transform.position = transform.position;
        g.GetComponent<MeshRenderer>().materials[0].color = materials[index].color;

    }
    private void activeSpawnOnj()
    {
        spawnObj.SetActive(true);
    }
}
