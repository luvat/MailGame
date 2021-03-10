using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public int movementSpeed = 5; //Variabel för hur fort Mailman ska kunna gå. Kan också ändras genom unity då-Elanor
    
    void Start()
    {
        
    }

    void Update()
    {
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
