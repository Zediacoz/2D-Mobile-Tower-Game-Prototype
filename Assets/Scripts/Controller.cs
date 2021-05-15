using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    [HideInInspector]
    public Box currentBox;

    public static Controller instance;

    public Spawner box_Spawner;
    public CameraU cameraScript;

    private int moveCount;

    public void Awake()
    {
        if (instance == null)
            instance = this;
    }
	
	public void Start ()
    {

        box_Spawner.BoxSpawn();

	}
	
	public void Update ()
    {
        DetectInput();

    }

    public void DetectInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();
        }
    }

    public void SpawnNewBox()
    {
        Invoke("NewBox", 1f);
    }

    public void NewBox()
    {
        box_Spawner.BoxSpawn();
    }

    public void MoveCamera()
    {
        moveCount++;

        if(moveCount == 3)
        {
            moveCount = 0;
            cameraScript.targetPos.y += 3f;
        }
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
        UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }


}
