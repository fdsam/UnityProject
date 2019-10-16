using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Transform player;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //player = GetComponent<GameObject>()
 ;    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0.0f, vertical);

        player.transform.Translate(move * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.Q))
        {
            player.transform.Rotate(0,10,0);
        }
        
    }
}
