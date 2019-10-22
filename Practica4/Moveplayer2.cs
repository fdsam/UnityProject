using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer2 : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            rb.AddForce(0, 0, -1, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            rb.AddForce(1, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            rb.AddForce(-1, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.AddForce(0, 0, 1, ForceMode.Impulse);
        }
    }
}
