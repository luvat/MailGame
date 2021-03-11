using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public int movementSpeed = 5; //Variabel för hur fort Mailman ska kunna gå, kan också ändras genom unity då-Elanor


    public Rigidbody2D body; // Referens till RigedBody2D i player-Elanor
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); //Den hämtar Rigedbody2D och sätter in det i body-Elanor
    }
    
    void Update()
    {
        float vert = Input.GetAxis("Vertical"); //Kollar om man klickar på upp och ned -Elanor
        float horizont = Input.GetAxis("Horizontal"); //Kollar om man klickar på höger och vänster -Elanor

        body.velocity = new Vector3(horizont * movementSpeed * Time.deltaTime, body.velocity.y, vert * movementSpeed * Time.deltaTime); //ökar och flyttar spelaren genom att ge en velocity -Elanor

        if (Input.GetKey(KeyCode.W))
        {
            body.velocity = (new Vector3(body.velocity.x,movementSpeed * Time.deltaTime, 0)); //Gör så att om man trycker på W kommer mailman röra sig uppåt-Elanor
        }
        if (Input.GetKey(KeyCode.S))
        {
            body.velocity = (new Vector3(body.velocity.x, -movementSpeed * Time.deltaTime, 0)); //Gör så att om man trcker på S kommer Mailman röra sig neråt-Elanor
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            body.velocity = (new Vector3(body.velocity.x, 0, 0)); //Gör så att om man släpper på W kommer mailman sluta röra sig uppåt-Elanor
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            body.velocity = (new Vector3(body.velocity.x, 0, 0)); //Gör så att om man släpper på S kommer mailman sluta röra sig uppåt-Elanor
        }
    }
}
