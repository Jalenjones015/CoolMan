using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text display;


   
    
    public Rigidbody Ball;
    public Vector3 ForceOnCollision;
    public Text scoreDisplay;
    private int score = 0;
    public GameObject Prefab;

    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Ball.AddForce(ForceOnCollision);
        score++;
        scoreDisplay.text = score.ToString();

        Vector3 OnCollisionPoint = collision.GetContact(0).point;

    }

}
