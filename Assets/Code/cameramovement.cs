using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public Transform player;//Referens till player- elanor

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 4, player.transform.position.z - 10); //Gör att den följer efter player i alla vinklar- Elanor
    }
}
