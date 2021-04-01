using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    public int movementSpeed = 5; //Variabel för hur fort Mailman ska kunna gå, kan också ändras genom unity då-Elanor

    public GameObject text; //Referens till text gameobject - Elanor
    public Text dialog; //Referens till UI:n vad som står. -Elanor
    public int dialogcounter = 0;// Visar att dialog countern är på 0 när man börjar-Elanor
    public int dialogcounterLittleBoy = 0; //Dialogcounterlittle boy börjar på 0- elanor.
    public bool showText = false; //Betyder att showtext är falsk i början- elanor
    public bool showText2 = false; //Betyder att showtext2 är falsk i början-elanor
    public Animator movement; //Referens till animator- elanor

    public Rigidbody2D body; // Referens till RigedBody2D i player-Elanor

    void Start()
    {
        body = GetComponent<Rigidbody2D>(); //Den hämtar Rigedbody2D och sätter in det i body-Elanor
    }
    
    void Update()
    {
       // float vert = Input.GetAxis("Vertical"); //Kollar om man klickar på upp och ned -Elanor
        //float horizont = Input.GetAxis("Horizontal"); //Kollar om man klickar på höger och vänster -Elanor

       // body.velocity = new Vector3(horizont * movementSpeed * Time.deltaTime, body.velocity.y, vert * movementSpeed * Time.deltaTime); //ökar och flyttar spelaren genom att ge en velocity -Elanor

        if (Input.GetKey(KeyCode.W)) //Om man trycker på W?- Elanor
        {
            body.velocity = (new Vector3(body.velocity.x,movementSpeed * Time.deltaTime, 0)); //Gör så att om man trycker på W kommer mailman röra sig uppåt-Elanor
            movement.SetBool("walkup", true); //Blir animator walkup true- elanor
        }
        if (Input.GetKey(KeyCode.S)) //om man trycker ner S?-elanor
        {
            body.velocity = (new Vector3(body.velocity.x, -movementSpeed * Time.deltaTime, 0)); //Gör så att om man trcker på S kommer Mailman röra sig neråt-Elanor
            movement.SetBool("walkdown", true); //Blir animation walkdown true -elanor
        }

        if (Input.GetKeyUp(KeyCode.W))//Om man trycker på W?- Elanor
        {
            body.velocity = (new Vector3(body.velocity.x, 0, 0)); //Gör så att om man släpper på W kommer mailman sluta röra sig uppåt-Elanor
            movement.SetBool("walkup", false); //Blir animator walkup falsk- elanor
        }
        if (Input.GetKeyUp(KeyCode.S)) //Om man trycker ner S?
        {
            body.velocity = (new Vector3(body.velocity.x, 0, 0)); //Gör så att om man släpper på S kommer mailman sluta röra sig uppåt-Elanor
            movement.SetBool("walkdown", false); //Blir animation walkdown falsk -elanor
        }
        if (Input.GetKey(KeyCode.D)) //Om man trycker ner D?-elanor
        {
            body.velocity = (new Vector3(movementSpeed * Time.deltaTime, body.velocity.y, 0)); //Gör så att om man trycker på W kommer mailman röra sig uppåt-Elanor
            movement.SetBool("walkleftright", true); //blir walkleftright true- elanor
        }
        if (Input.GetKeyUp(KeyCode.D)) //Om man släpper D?-elanor
        {
            body.velocity = (new Vector3(0, body.velocity.y, 0)); //Gör så att om man trycker på W kommer mailman röra sig uppåt-Elanor
            movement.SetBool("walkleftright", false); //blir walkleftright false- elanor
        }
        if (Input.GetKey(KeyCode.A)) //Om man trycker ner A?-elanor
        {
            body.velocity = (new Vector3(-movementSpeed * Time.deltaTime, body.velocity.y, 0)); //Gör så att om man trycker på A kommer mailman röra sig vänster-Elanor
            movement.SetBool("walkleftright", true);  //blir walkleftright true- elanor
            transform.eulerAngles = new Vector3(0, 180, 0); //Gör att spriten kommer ändra sig så att den blir åt vänster - elanor
        }
        if (Input.GetKeyUp(KeyCode.A)) //Om man släpper A?-elanor
        {
            body.velocity = (new Vector3(0, -body.velocity.y, 0)); //Gör så att om man släpper A kommer mailman sluta röra sig vänster-Elanor
            movement.SetBool("walkleftright", false); //blir walkleftright false- elanor
            transform.eulerAngles = new Vector3(0, 0, 0); //Gör att vinkeln inte kommer ändras när den blir falsk- elanor
        }

        if (Input.GetKeyUp(KeyCode.T) && showText)//Om man klickar T och Showtext är sann?-Elanor
        {
            dialogcounter += 1; //Dialogcounter ökar med en varje gång man trycker på T- Elanor 

            switch (dialogcounter) //Switch till Dialogcounter så att när man trycker T igen ska Nästa Case hända-Elanor 
            {
                case 1: //Gör så att när man trycker T igen så kommer första Dialogen upp- Elanor 
                    dialog.text = "Oh is this the letter from my son?";

                    break;
                case 2:// Dialog 2 kommer upp - Elanor
                    dialog.text = "It must be from him"; //Det som ska komma upp på skärmen här(Dialogen) -Elanor 
                    break;
                case 3: //Nästa dialog kommer upp -Elanor 
                    dialog.text = "He was in the war and sadly he \n passed away…";
                    break;
                case 4: //Nästa dialog kommer upp -Elanor
                    dialog.text = "But...";
                    break;
                case 5://Nästa dialog kommer upp -Elanor
                    dialog.text = "He served the city and saved us";
                    break;
                case 6://Nästa dialog kommer upp -Elanor.
                    dialog.text = "I really miss him";
                    break;
                case 7://och så fortsätter det ^^
                    dialog.text = "Oh Tigger";
                    break;
                case 8:
                    dialog.text = "You probably don't understand, but \n this was his cat, Tigger";
                    break;
                case 9:
                    dialog.text = "It's the last thing i have from him";
                    break;
                case 10:
                    dialog.text = "But you, you gave me his last words";
                    break;
                case 11:
                    dialog.text = "Thank you for giving me \n this letter";
                    break;
            }

        }
        if (Input.GetKeyUp(KeyCode.T) && showText2)//Om man klickar T och Showtext2 är sann?-Elanor
        {
            dialogcounterLittleBoy += 1; //Dialogcounter ökar med en varje gång man trycker på T- Elanor 

            switch (dialogcounterLittleBoy) //Switch till Dialogcounterlittleboy så att när man trycker T igen ska Nästa Case hända-Elanor 
            {
                case 1: //Gör så att när man trycker T igen så kommer första Dialogen upp- Elanor 
                    dialog.text = "Dad! \n Its from him!";
                    break;
                case 2:// Dialog 2 kommer upp - Elanor
                    dialog.text = "My dad never returned from the war"; //Det som ska komma upp på skärmen här(Dialogen) -Elanor 
                    break;
                case 3: //Nästa dialog kommer upp -Elanor 
                    dialog.text = "I miss him";
                    break;
                case 4: //Nästa dialog kommer upp -Elanor
                    dialog.text = "It have been 8 months since he \n left for the war";
                    break;
                case 5://Nästa dialog kommer upp -Elanor
                    dialog.text = "And now I always come here";
                    break;
                case 6://Nästa dialog kommer upp -Elanor.
                    dialog.text = "Dreaming he's out there, happy";
                    break;
                case 7://och så fortsätter det ^^
                    dialog.text = "He always gonna be in my heart";
                    break;
                case 8:
                    dialog.text = "Thank you sir for giving me this letter! It made me very happy";
                    break;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "talk") //Om man är inaför collisonen?-Elanor
        {
            text.SetActive(true); //Kommer UI:n inte att synas-Elanor
            if (!showText) //Om showtexten är false- Elanor
            {
                dialog.text = "Press 'T'"; //Gör så att om du går in i colliderna så kommer texten "press T" komma fram- Elanor
            }
            showText = true; //Gör att om man är innanför collisonen så är showText sann-Elanor
        }
        if (collision.transform.tag == "Littleboytalk") //Om man är inaför collisonen?-Elanor
        {
            text.SetActive(true); //Kommer UI:n inte att synas-Elanor
            if (!showText2) //Om showtext2 är false- Elanor
            {
                dialog.text = "Press 'T'"; //Gör så att om du går in i colliderna så kommer texten "press T" komma fram- Elanor
            }
            showText2 = true; //Gör att om man är innanför collisonen så är showText2 sann-Elanor
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.transform.tag == "talk" || collision.transform.tag == "Littleboytalk") //Om man är inte är inaför collisonen?-Elanor
         {
            text.SetActive(false); //Kommer UI:n inte att synas-Elanor
            showText = false; //Showtext blir false -Elanor
            showText2 = false; //Show text2 blir falsk -Elanor
            dialogcounter = 0;// Gör så att Dialog countern blir på 0 igen om man går ut från collison- Elanor
            dialogcounterLittleBoy = 0; //Gör så att Dialogcountern till lilla pojken blir till 0 igen om man går ut från collison- Elanor
         }         
    }
}
