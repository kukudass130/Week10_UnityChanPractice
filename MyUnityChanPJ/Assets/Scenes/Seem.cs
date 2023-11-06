using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seem : MonoBehaviour
{
    Player player;
    public float limitTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find(name: "Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0);
        Destroy(gameObject, limitTime);
    }

}

