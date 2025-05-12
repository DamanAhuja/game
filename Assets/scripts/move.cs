using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public int speed = 5;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown("w"))
        {
            rb.velocity = new Vector3(0,0,-11);
        }
        if (Input.GetKeyDown("a"))
        {
            rb.velocity = new Vector3(11,0,0);
        }
        if (Input.GetKeyDown("d"))
        {
            rb.velocity = new Vector3(-11,0,0);
        }
        if (Input.GetKeyDown("k"))
        {
            rb.velocity = new Vector3(0,0,11);
        }
    }
} 
