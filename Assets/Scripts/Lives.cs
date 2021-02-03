using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{

    public int Liv;
    public int LivC;
    public Text LiveT;
    public Manager gm;
    public GameObject em;

    public void Start()
    {
        LivC = PlayerPrefs.GetInt("Liv");
        gm = FindObjectOfType<Manager>();
       
    }

    public void Update()
    {
        LiveT.text = "x " + LivC;

        if(LivC <1)
        {
            gm.Lose();
            em.gameObject.SetActive(false);
        }
    }

    public void takelife()
    {
        LivC --;
        PlayerPrefs.SetInt("liv", LivC);
        Debug.Log("Plz");
    }

    public void gainlife()
    {
        LivC++;
        PlayerPrefs.SetInt("liv", LivC);
        Debug.Log("Plz2");
    }
}
