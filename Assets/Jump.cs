using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D body;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    [SerializeField]
    Vector3 velocity;

    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            body.AddForce(new Vector3(0, 350, 0));
            isGrounded = false;
            
        }

       




    }


}

