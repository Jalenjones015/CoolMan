using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Manager gm;
    public GameObject em;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Win");
            gm.Win();
            em.gameObject.SetActive(false);
        }
    }
}
