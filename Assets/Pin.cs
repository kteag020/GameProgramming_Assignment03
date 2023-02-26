using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed;
    public Rigidbody2D rb;
    float newspeed = SpeedManager.Speed;

    void Update ()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * newspeed * Time.deltaTime);

    }
        
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned= true; 
        } else if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
