using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    public int movementSpeed = 5; //Variabel för hur fort Mailman ska kunna gå, kan också ändras genom unity då-Elanor

    public GameObject text; //Referens till text gameobject - Elanor
    public Text dialog; //Referens till UI:n vad som står. -Elanor

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
    private void OnTriggerStay2D(Collider2D collision)
    {  if (Input.GetKeyDown(KeyCode.T)) //Gör så att om man är innanför collisonen och trycker på T så kommer texten komma up-Elanor
        {
            if (collision.transform.tag == "talk") //Om man är inaför collisonen?-Elanor
            {
                text.SetActive(true); //Så kommer UI:n synas (alltså det jag kommer ha skrivt kommer synas)-Elanor 
                dialog.text = "heej";
            }
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.transform.tag == "talk") //Om man är inte är inaför collisonen?-Elanor
         {
              text.SetActive(false); //Kommer UI:n inte att synas-Elanor
         }
           
    }
}
