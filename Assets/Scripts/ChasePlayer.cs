using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public GameObject player;
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < player.transform.position.z)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        } else
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (transform.position.x < player.transform.position.x)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
