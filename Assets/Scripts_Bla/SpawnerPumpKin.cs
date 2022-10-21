using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPumpkin : MonoBehaviour
{
    public GameObject Pumpkin;

    public GameObject Sign;

    private bool playerInTrigger;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInTrigger == true)
        {
            Instantiate(Pumpkin, transform.position, Quaternion.identity);
        }

    }

}