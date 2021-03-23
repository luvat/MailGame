using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    public int movementSpeed = 5; //Variabel för hur fort Mailman ska kunna gå, kan också ändras genom unity då-Elanor

    public GameObject text; //Referens till text gameobject - Elanor
    public Text dialog; //Referens till UI:n vad som står. -Elanor
    public int dialogcounter = 0;

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
    {
        if (collision.transform.tag == "talk") //Om man är inaför collisonen?-Elanor
        {
            dialog.text = "Press 'T'"; //Gör så att om du går in i colliderna så kommer texten "press T" komma fram- Elanor

            if (Input.GetKeyDown(KeyCode.T))

            
            dialogcounter += 1; //Dialogcounter ökar med en varje gång man trycker på T.
             
            switch (dialogcounter) //Switch till Dialogcounter så att när man trycker T igen ska Nästa Case hända. 
            {
                case 1: //Gör så att när man trycker T igen så kommer första Dialogen upp.
                    dialog.text = "Oh is this the letter from my son?"; 

                    break;
                case 2://Gör att Dialog 1 försvinner och att Dialog 2 kommer upp.
                    dialog.text = "It must be from him";
                    break;
                case 3: //Gör att Dialog 2 försvinner och att Dialog 3 kommer upp.
                    
                    break;
                case 4: //Gör att Dialog 3 försvinner och att Dialog 4 kommer upp.
                    
                    break;
                case 5://Gör att Dialog 4 försvinner och att Dialog 5 kommer upp.
                    
                    break;
                case 6://Gör att Dialog 5 försvinner och att Dialog 6 kommer upp.
                    
                    break;
                case 7://Gör att Dialog 6 försvinner och att Dialog 7 kommer upp.
                    
                    break;
            }
        }
        /* if (collision.transform.tag == "talk") //Om man är inaför collisonen?-Elanor
         {
             if (Input.GetKeyDown(KeyCode.T)) //Gör så att om man är innanför collisonen och trycker på T så kommer texten komma up-Elanor
             {
                 text.SetActive(true); //Så kommer UI:n synas (alltså det jag kommer ha skrivt kommer synas)-Elanor 
                 dialog.text = "heej"; //Texten över vad som ska stå i spelet- Elanor
             }
             if (Input.GetKeyDown(KeyCode.Space))
             {
                 dialog.text = "whats up";
             }
         }*/

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.transform.tag == "talk") //Om man är inte är inaför collisonen?-Elanor
         {
              text.SetActive(false); //Kommer UI:n inte att synas-Elanor
         }
           
    }
}
