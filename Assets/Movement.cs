using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public int movementSpeed = 5; //Variabel för hur fort Mailman ska kunna gå. Kan också ändras genom unity då-Elanor

    public Rigidbody2D body; //-Elanor
    void Start()
    {
        /*body = GetComponent<Rigidbody2D>();*/
    }
    
    void Update()
    {
        /*float vert = Input.GetAxis("Vertical"); //Kollar om man klickar på upp och ned -Elanor
        float horizont = Input.GetAxis("Horizontal"); //Kollar om man klickar på höger och vänster -Elanor

        body.velocity = new Vector3(horizont * movementSpeed * Time.deltaTime, body.velocity.y, vert * movementSpeed * Time.deltaTime);*/ //ökar och flyttar spelaren genom att ge en velocity -Elanor

        //Movement för Mailman-Elanor
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (new Vector3(movementSpeed * Time.deltaTime, 0, 0)); //Gör så att Mailman kan röra sig åt höger om man trycker ner D-Elanor
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (new Vector3(-movementSpeed * Time.deltaTime, 0, 0)); // Gör så att om man trycker ner A kommer Mailman röra sig åt vänster-Elanor
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (new Vector3(0,movementSpeed * Time.deltaTime, 0)); //Gör så att om man trycker på W kommer mailman röra sig uppåt-Elanor
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (new Vector3(0, -movementSpeed * Time.deltaTime, 0)); //Gör så att om man trcker på S kommer Mailman röra sig neråt-Elanor
        }
    }
}
