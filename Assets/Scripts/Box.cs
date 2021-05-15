using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Box : MonoBehaviour {

    private Rigidbody2D myBody;

    private float min_X = -1.67f, max_X = 1.67f; 
    private float move_Speed = 2f;

    private bool can_Move;
    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;

    public void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
    }

    public void Start()
    {
        can_Move = true;

        if (Random.Range(0, 2) > 0)
        {
            move_Speed *= -1f;
        }
        Controller.instance.currentBox = this;
    }

    public void Update()
    {
        MoveBox();
    }

    public void MoveBox()
    {
        if (can_Move)
        {
            Vector3 temp = transform.position;
            temp.x += move_Speed * Time.deltaTime;

            if(temp.x > max_X)
            {
                move_Speed *= -1f;
            }else if (temp.x < min_X)
            {
                move_Speed *= -1f;
            }
            transform.position = temp;
        }
    }


    public void DropBox()
    {
        can_Move = false;
        myBody.gravityScale = Random.Range(2, 4);
    }


    public void Landed()
    {
        if (gameOver)
            return;
        ignoreCollision = true;
        ignoreTrigger = true;
        Controller.instance.SpawnNewBox();
        Controller.instance.MoveCamera();
    }


    public void RestartGame()
    {
        Controller.instance.RestartGame();

    }

    public void OnCollisionEnter2D(Collision2D target)
    {
        if (ignoreCollision)
            return;

        if (target.gameObject.tag == "Platform")
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;
        }

        if (target.gameObject.tag == "Box")
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D target)
    {
        if (ignoreTrigger)
            return;

        if (target.tag == "GameOver")
        {
            CancelInvoke("Landed");
            gameOver = true;
            ignoreTrigger = true;
            SceneManager.LoadScene(6);
            //Invoke("RestartGame", 2f);
        }
    }


}

