using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    public GameObject Bob;
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;

   public void Update()
    {
        if (Input.GetKey(right))
        {
            Bob.transform.Translate(new Vector2(speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(left))
        {
            Bob.transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
        }

        if (Input.GetKeyDown(jump))
        {
            Bob.transform.Translate(new Vector2(0, 2f));
        }
    }
}
