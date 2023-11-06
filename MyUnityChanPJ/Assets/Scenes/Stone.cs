using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    Player player;
    public float speed = -1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find(name: "Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        if (transform.position.y <= 1)
        {
            Destroy(gameObject);
        }
    }
}
