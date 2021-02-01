using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float Smoove;

    void Update()
    {
        follow();
    }

    void follow()
    {
        Vector3 playerPosition = player.position + offset;
        Vector3 smoovePosition = Vector3.Lerp(transform.position, playerPosition, Smoove * Time.deltaTime);
        transform.position = playerPosition;
    }
}
