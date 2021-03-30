using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D body;
    public Rigidbody2D player;
    public int direction;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    [SerializeField]
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            player.velocity = new Vector3(10, player.velocity.y, 0);

            direction = 1;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            player.velocity = new Vector3(0, player.velocity.y, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocity = new Vector3(-10, player.velocity.y, 0);
            direction = 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            player.velocity = new Vector3(0, player.velocity.y, 0);
        }
        //Gör så att man kan röra sig, och också så att man slutar röra sig när man inte håller ner tangenten (Victor)
    }

}
