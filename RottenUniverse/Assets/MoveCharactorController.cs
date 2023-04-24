using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorController : MonoBehaviour
{
    Vector2 position;
    private float speed = 0.015f;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void GoX(){
            if(position.x < 7.8)
                position.x += speed;
    }

        public void BackX(){
            if(position.x > -7.8)
                position.x -= speed;
    }

        public void GoY(){
            if(position.y < 4.5)
                position.y += speed;
    }

        public void BackY(){
            if(position.y > -4.7)
                position.y -= speed;
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;

        if (Input.GetKey("left") && Input.GetKey("down"))
        {
                BackX();
                BackY();
        }
        else if (Input.GetKey("left") && Input.GetKey("up"))
        {
            BackX();
            GoY();
        }
        else if (Input.GetKey("right") && Input.GetKey("down"))
        {
            GoX();
            BackY();
        }
        else if (Input.GetKey("right") && Input.GetKey("up"))
        {
            GoX();
            GoY();
        }
        else if (Input.GetKey("left") && Input.GetKey("right"))
        {
        }
        else if (Input.GetKey("up") && Input.GetKey("down"))
        {
        }
        else if (Input.GetKey("left"))
        {
            BackX();
        }
        else if (Input.GetKey("right"))
        {
            GoX();
        }
        else if (Input.GetKey("up"))
        {
            GoY();
        }
        else if (Input.GetKey("down"))
        {
            BackY();
        }

        transform.position = position;
    }
}
