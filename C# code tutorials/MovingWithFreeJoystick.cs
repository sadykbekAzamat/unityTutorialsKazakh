using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ibeta : MonoBehaviour
{
    public FixedJoystick joystick;  //<- джойстикті қосу
    Rigidbody2D rb;                 //<- қозғалатын дене екенін көрсету
    Vector2 move;                   //<- ойын кезіндегі жылдамдық
    public float moveSpeed;         //<- негізгі жылдамдық

    float rotation;                 //<- бұрылуды сақтау


    private void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        //джойстикпен қозғалыс
        move.x = joystick.Horizontal;
        move.y = joystick.Vertical;

        //бұрылу

        if(move.x == 0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, rotation);
        }
        else
        {
            float hAxis = move.x;
            float vAxis = move.y;
            float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0f, 0f, -zAxis);
            rotation = -zAxis;
        }
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
