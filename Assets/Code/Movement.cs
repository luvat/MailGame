using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    public int movementSpeed = 5; //Variabel för hur fort Mailman ska kunna gå, kan också ändras genom unity då-Elanor

    public GameObject text; //Referens till text gameobject - Elanor
    public Text dialog; //Referens till UI:n vad som står. -Elanor
    public int dialogcounter = 0;// Visar att dialog countern är på 0 när man börjar-Elanor
    public int dialogcounterLittleBoy = 0; //Dialogcounterlittle boy börjar på 0- elanor.
    public int dialogcountergirlrobotarm = 0; //dialogcountergirlrobotarm börjar på 0-elanor
    public int dialogrobot = 0; //dialogrobit börjar på 0-elanor
    public int dialogoldlady = 0; //dialogoldlady börjar på 0-elanor
    public int dialogCat = 0; //dialogCat börjar på 0 -Ian
    public bool showText = false; //Betyder att showtext är falsk i början- elanor
    public bool showText2 = false; //Betyder att showtext2 är falsk i början-elanor
    public bool showText3 = false; //Betyder att showtext3 är falsk- elanor
    public bool showtext4 = false; //Betyder att showtext3 är falsk-Elanor
    public bool showtext5 = false; //Betyder att showtext4 är falsk- elanor
    public Animator movement; //Referens till animator- elanor
    public bool showtext6 = false; //showtext6 håller sig falsk- Ian
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

        if (Input.GetKeyUp(KeyCode.T) && showText3)//Om man klickar T och Showtext är sann?-Elanor
        {
            dialogcountergirlrobotarm += 1; //Dialogcounter ökar med en varje gång man trycker på T- Elanor 

            switch (dialogcountergirlrobotarm) //Switch till dialogcountergirlrobotarm så att när man trycker T igen ska Nästa Case hända-Elanor 
            {
                case 1: //Gör så att när man trycker T igen så kommer första Dialogen upp- Elanor 
                    dialog.text = "Oh it's for me? Thanks for the letter!";

                    break;
                case 2:// Dialog 3 kommer upp - Elanor
                    dialog.text = "It's a letter from some people in the war"; //Det som ska komma upp på skärmen här(Dialogen) -Elanor 
                    break;
                case 3: //Nästa dialog kommer upp -Elanor 
                    dialog.text = "I used to fight, it was really difficult but \n I was one of the best soldiers in my team";
                    break;
                case 4: //Nästa dialog kommer upp -Elanor
                    dialog.text = "I lost several of my teammates..";
                    break;
                case 5://Nästa dialog kommer upp -Elanor
                    dialog.text = "And my arms where severely damaged";
                    break;
                case 6://Nästa dialog kommer upp -Elanor
                    dialog.text = "So I got two new ones, as you can see";
                    break;
                case 7://och så fortsätter det ^^
                    dialog.text = "And I quickly realized how much power I had";
                    break;
                case 8:
                    dialog.text = "I became the best in the team with my new mechanical arms ";
                    break;
                case 9:
                    dialog.text = "Our team did well and I got several medals";
                    break;
                case 10:
                    dialog.text = "I have now realized that I was just eager to be the best \n I was a killing machine back then";
                    break;
                case 11:
                    dialog.text = "After my last mission I couldn't fight anymore \n My arms and my mind was to hurt";
                    break;
                case 12:
                    dialog.text = "I can now see how blind and eager I was \n And I just wish that war never existed";
                    break;
                case 13:
                    dialog.text = "Please never think that war is good \n It's a terrible thing that changes people";
                    break;
                case 14:
                    dialog.text = "Thank you for the letter";
                    break;                   
            }
        }

        if (Input.GetKeyUp(KeyCode.T) && showtext4)//Om man klickar T och Showtext är sann?-Elanor
        {
            dialogrobot += 1; //Dialogcounter ökar med en varje gång man trycker på T- Elanor 

            switch (dialogrobot) //Switch till Dialogcounter så att när man trycker T igen ska Nästa Case hända-Elanor 
            {
                case 1: //Gör så att när man trycker T igen så kommer första Dialogen upp- Elanor 
                    dialog.text = "Beep Bep Bop";
                    break;
                case 2:// Dialog 2 kommer upp - Elanor
                    dialog.text = "I..s^ ThE wAR OvEr ..? Bep Bop"; //Det som ska komma upp på skärmen här(Dialogen) -Elanor 
                    break;
                case 3: //Nästa dialog kommer upp -Elanor 
                    dialog.text = "oNe dAY tHEy just ThreW mE here";
                    break;
                case 4: //Nästa dialog kommer upp -Elanor
                    dialog.text = "And then they never came back...";
                    break;
                case 5:
                    dialog.text = "ThANk yOu For thIs LetTer";
                    break;
            }
        }
        if (Input.GetKeyUp(KeyCode.T) && showtext5)//Om man klickar T och Showtext5 är sann?-Elanor
        {
             dialogoldlady+= 1; //Dialogoldlady ökar med en varje gång man trycker på T- Elanor 

            switch (dialogoldlady) //Switch till dialogoldlady så att när man trycker T igen ska Nästa Case hända-Elanor 
            {
                case 1: //Gör så att när man trycker T igen så kommer första Dialogen upp- Elanor 
                    dialog.text = "Oh my lord!";
                    break;
                case 2:// Dialog 2 kommer upp - Elanor
                    dialog.text = "It's from him, Thank you!"; //Det som ska komma upp på skärmen här(Dialogen) -Elanor 
                    break;
                case 3: //Nästa dialog kommer upp -Elanor 
                    dialog.text = "He haven't came back yet, he needed to stay longer in the war \n because he is such a good soldier";
                    break;
                case 4: //Nästa dialog kommer upp -Elanor
                    dialog.text = "But I really want him to come back now, he's missing me sooo much";
                    break;
                case 5://Nästa dialog kommer upp -Elanor
                    dialog.text = "I feel so sorry for him, He needs to live on the ground \n in a tent? Can you believe that!?";
                    break;
                case 6://Nästa dialog kommer upp -Elanor.
                    dialog.text = "I really hope that he's alright tho, I just want him to be safe";
                    break;
                case 7://och så fortsätter det ^^
                    dialog.text = "What if something happens to him? \n I'm just worried for him";
                    break;
                case 8:
                    dialog.text = "I just want him to come home";
                    break;
                case 9:
                    dialog.text = "Thank you for delivering this to me";
                    break;
            }
        }

        if (Input.GetKeyUp(KeyCode.T) && showtext6)//Om man klickar T och Showtext är sann -Ian
        {
            dialogCat += 1; //Dialogcounter ökar med en varje gång man trycker på T- Ian

            switch (dialogCat) //Switch till Dialogcounter så att när man trycker T igen ska Nästa Case hända- Ian
            {
                case 1: //Gör så att när man trycker T igen så kommer första Dialogen upp- Ian
                    dialog.text = "Meow?";
                    break;
                case 2:// Dialog 2 kommer upp - Ian
                    dialog.text = "John where is my lasagna?" ; //Det som ska komma upp på skärmen här(Dialogen) -Ian
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

        if (collision.transform.tag == "girlrobotarmtalk") //Om man är inaför collisonen?-Elanor
        {
            text.SetActive(true); //Kommer UI:n inte att synas-Elanor
            if (!showText) //Om showtexten är false- Elanor
            {
                dialog.text = "Press 'T'"; //Gör så att om du går in i colliderna så kommer texten "press T" komma fram- Elanor
            }
            showText3 = true; //Gör att om man är innanför collisonen så är showText3 sann-Elanor
        }

        if (collision.transform.tag == "Robottalk") //Om man är inaför collisonen?-Elanor
        {
            text.SetActive(true); //Kommer UI:n inte att synas-Elanor
            if (!showText) //Om showtexten är false- Elanor
            {
                dialog.text = "Press 'T'"; //Gör så att om du går in i colliderna så kommer texten "press T" komma fram- Elanor
            }
            showtext4 = true; //Gör att om man är innanför collisonen så är showText4 sann-Elanor
        }

        if (collision.transform.tag == "Oldwomantalk") //Om man är inaför collisonen?-Elanor
        {
            text.SetActive(true); //Kommer UI:n inte att synas-Elanor
            if (!showText) //Om showtexten är false- Elanor
            {
                dialog.text = "Press 'T'"; //Gör så att om du går in i colliderna så kommer texten "press T" komma fram- Elanor
            }
            showtext5 = true; //Gör att om man är innanför collisonen så är showText5 sann-Elanor
        }

        if (collision.transform.tag == "Cattalk") //Om man är inaför collidern -Ian
        {
            text.SetActive(true); //Kommer UI:n inte att synas -Ian
            if (!showText) //Om showtexten är false -Ian
            {
                dialog.text = "Press 'T'"; //Gör så att om du går in i collidern så kommer texten "press T" titta fram -Ian
            }
            showtext6 = true; //Gör att om man är innanför collidern så är showText6 sann -Ian
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.transform.tag == "talk" || collision.transform.tag == "Littleboytalk" || collision.transform.tag == "girlrobotarmtalk" || collision.transform.tag == "Robottalk" || collision.transform.tag == "Oldwomantalk" || collision.transform.tag == "Cattalk") //Om man inte är inaför collisonen -Elanor/Ian
         {
            text.SetActive(false); //Kommer UI:n inte att synas-Elanor
            showText = false; //Showtext blir false -Elanor
            showText2 = false; //Show text2 blir falsk -Elanor
            showText3 = false; //Show text3 blir falsk -Elanor
            showtext4 = false; //Show text4 blir falsk -Elanor
            showtext5 = false; //Show text5 blir falsk -Elanor
            showtext6 = false; //show text6 förblir falsk -Ian
            dialogcounter = 0;// Gör så att Dialog countern blir på 0 igen om man går ut från collison- Elanor
            dialogcounterLittleBoy = 0; //Gör så att Dialogcountern till lilla pojken blir till 0 igen om man går ut från collison- Elanor
            dialogcountergirlrobotarm = 0; //Gör att dialogcountergirlrobotarm blir till 0 om man går ut från dens collison- Elanor
            dialogrobot = 0; //Gör att dialogrobot blir på 0 om man går ut ur collider- elanor
            dialogoldlady = 0; //Gör att dialogoldlady blir på 0 om man går ut ur collider - elanor
            dialogCat = 0; //dialogCat hamnar på 0 om man går ut ur collidern -Ian
         }         
    }
}
