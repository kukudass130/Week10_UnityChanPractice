using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 0.1f;
    public float jumpPower = 8;
    TextMesh scoreOutput;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreOutput = GameObject.Find(name: "Score"). GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(0, 0, speed);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(0, 0, -speed);
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }

    }

    public void addScore(int s)
    {
        score = score + s;
        scoreOutput.text = "½ÉºÃ´Ù!x"+score;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Tree>() != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.GetComponent<Stone>() != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.GetComponent<Seem>() != null)
        {
            addScore(1);
            Destroy(collision.gameObject);
            Debug.Log("seem");
        }
    }
}
