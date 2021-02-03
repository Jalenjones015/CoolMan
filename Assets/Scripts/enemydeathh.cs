using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydeathh : MonoBehaviour
{
   
    public GameObject DB;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}


