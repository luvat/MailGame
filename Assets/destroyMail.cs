using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMail : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit detected");

        Destroy(other.gameObject);

    }
}
