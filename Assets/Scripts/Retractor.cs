using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retractor : MonoBehaviour
{
    public bool retracted = false;

    Rigidbody2D myBody;

    Rigidbody2D ropeHolderBody;



    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();

        ropeHolderBody = transform.GetChild(0).GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            retracted = true;

            transform.position = new Vector3(transform.position.x, 45f, 0);

            ropeHolderBody.isKinematic = true;




        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            retracted = false;

            ropeHolderBody.isKinematic = false;

            transform.position = new Vector3(transform.position.x, 18.4f, 0);


            
        }
    }
}