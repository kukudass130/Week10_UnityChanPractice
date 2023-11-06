using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject TreePrefab;
    public GameObject StonePrefab;
    public float interval = 1.5f;
    float term;
    float range = 50;

    // Start is called before the first frame update
    void Start()
    {
        term = interval;

    }

    // Update is called once per frame
    void Update()
    {
        term += Time.deltaTime;
        if(term >= interval)
        {
            Vector3 pos = transform.position;
            pos.z += Random.Range(-range, range);
            if (Random.Range(0, 2) == 0)
                Instantiate(TreePrefab, pos, transform.rotation);
            if (Random.Range(0, 2) == 0)
                Instantiate(StonePrefab, pos, transform.rotation);
            term -= interval;
        }
    }
}
