using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;

public class MailGiver : MonoBehaviour
{
   //detects the dragging of the object
    private bool isDragging;

    public void OnMouseDown() //När du klickar ned med musen så börjar den dra.
    {
        isDragging=true;
        Debug.Log("true");
    }

    private void OnMouseUp() //När du släpper musen slutar den dra.
    {
        isDragging = false;
        Debug.Log("false");
    }
    private void Update()
    {
        
        if (isDragging) //Om du klickar ned musen så börjar brevet röra sig.
        {
            Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mouseposition);
        }
    }

   

}
