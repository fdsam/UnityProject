using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform player;
    public float speed = 5;
    public GameObject esfera;
    public GameObject cilindro;

    private Rigidbody rb;
    private int number;

   
    public Color redcolor;
    public Color bluecolor;
    public Color blackcolor;
   
    public int Number
    {
        get { return number; }
    }

    void Start()
    {
        //player = GetComponent<GameObject>()
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0.0f, vertical);

        //player.transform.Translate(move * Time.deltaTime * speed);
        rb.AddForce(move * speed);

        if (Input.GetKey(KeyCode.Q))
        {
            player.transform.Rotate(0, 10, 0);
        }

        esfera.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            number += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.GetComponent<Renderer>().material.color = redcolor;
    }

    private void OnTriggerExit(Collider other)
    {
        player.transform.GetComponent<Renderer>().material.color = bluecolor;
    }

    private void OnTriggerStay(Collider other)
    {
        player.transform.GetComponent<Renderer>().material.color = blackcolor;
    }

}
