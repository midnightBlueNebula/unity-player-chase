using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialDistancing : MonoBehaviour
{
    public GameObject[] alliesAmongEnemies;
    private float socialDistance = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<alliesAmongEnemies.Length; ++i)
        {
            float zDistance = transform.position.z - alliesAmongEnemies[i].transform.position.z;
            float xDistance = transform.position.x - alliesAmongEnemies[i].transform.position.x;

            if(zDistance < socialDistance && zDistance > 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * socialDistance);
            } else if(zDistance < socialDistance && zDistance < 0)
            {
                transform.Translate(Vector3.back * Time.deltaTime * socialDistance);
            }

            if (xDistance < socialDistance && xDistance > 0)
            {
                transform.Translate(Vector3.right * Time.deltaTime * socialDistance);
            }
            else if (xDistance < socialDistance && xDistance < 0)
            {
                transform.Translate(Vector3.left * Time.deltaTime * socialDistance);
            }
        }
    }
}
