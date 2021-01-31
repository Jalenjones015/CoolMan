using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    public GameObject Bob;
    public Rigidbody rig;
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public bool groundcube = true;
    

    public void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
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

        if (Input.GetKeyDown(jump) && groundcube)
        {
            rig.AddForce(new Vector2(0, 10), ForceMode.Impulse);
            groundcube = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            groundcube = true;
        }
    }
}
