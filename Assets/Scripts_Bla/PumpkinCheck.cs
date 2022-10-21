using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinCheck : MonoBehaviour
{
    private SpawnerPumpkin SpawnerPumpkin;

    public bool Occupied;

    private void OnTriggerEnter2D(Collider2D collision)
    {

      if (collision.gameObject.tag == "Pumpkin")
      {
          Debug.Log("Occupiced");
          SpawnerPumpkin.enabled = false;
          Occupied = true;
      }

       //else if (collision.gameObject.tag != "Pumpkin")
       //{
       //    Debug.Log("Vacant");
       //    SpawnerPumpkin.enabled = true;
       //}


    }

    private void Update()
    {
        if (Occupied == true)
        {
            Debug.Log("Vacant");
            SpawnerPumpkin.enabled = true;
            Occupied = false;
        }
    }
}
