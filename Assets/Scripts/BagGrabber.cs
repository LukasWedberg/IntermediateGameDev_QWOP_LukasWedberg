using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagGrabber : MonoBehaviour
{
    SpringJoint2D tether;


    // Start is called before the first frame update
    void Start()
    {
        tether = GetComponent<SpringJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.transform.parent != null && tether.enabled == false) {
            if (col.gameObject.transform.parent.gameObject.name == "Robin Dood")
            {
                Debug.Log("BUBUBBUBUBUB");

                tether.enabled = true;

                tether.connectedBody = col.rigidbody;
            }
        }
    }

}
