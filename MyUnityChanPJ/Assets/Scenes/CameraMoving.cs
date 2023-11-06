using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public Vector3 offset;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 FixedPos = 
            new Vector3(player.transform.position.x + offset.x, 
            player.transform.position.y+offset.y,
            player.transform.position.z+offset.z);
        transform.position = FixedPos;  
    }
}
