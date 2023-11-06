using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeemSpawner : MonoBehaviour
{
    public GameObject SeemPrefab;
    float term;
    float range = 50;
    public float interval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        term = interval;
    }

    // Update is called once per frame
    void Update()
    {
        term += Time.deltaTime;
        if (term >= interval)
        {
            Vector3 pos = transform.position;
            pos.z += Random.Range(-range, range);
            Instantiate(SeemPrefab, pos, transform.rotation);
            term -= interval;
        }
    }
}
