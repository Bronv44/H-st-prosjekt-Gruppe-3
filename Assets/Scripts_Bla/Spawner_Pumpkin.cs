using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Pumpkin;

    public float minwaitTime = 2f;
    public float maxwaitTime = 5f;

    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(minwaitTime, maxwaitTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= 1 * Time.deltaTime;
        }
        else
        {
            Instantiate(Pumpkin, transform.position, Quaternion.identity);
            time = Random.Range(minwaitTime, maxwaitTime);
        }

    }

}