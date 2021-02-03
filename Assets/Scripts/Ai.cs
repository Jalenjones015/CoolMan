using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Ai : MonoBehaviour
{
 
    public Transform Play;
    NavMeshAgent en;
    public Manager gm;
    public GameObject em;


    void Start()
    {
        en = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        en.SetDestination(Play.position);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EH") ;
        em.gameObject.SetActive(false);
        Debug.Log("Death");
        gm.Lose();
    }


}
