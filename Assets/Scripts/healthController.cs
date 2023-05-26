using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthController : MonoBehaviour
{
    public GameObject[] health;
    public int maxLifes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (maxLifes < 1)
        {
            Destroy(health[0].gameObject);
        }

        else if (maxLifes < 2)
        {
            Destroy(health[1].gameObject);
        }

        else if (maxLifes < 3)
        {
            Destroy(health[2].gameObject);
        }
    }
}
