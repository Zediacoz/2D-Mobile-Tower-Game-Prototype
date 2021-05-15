using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraU : MonoBehaviour {

    [HideInInspector]
    public Vector3 targetPos;

    private float smoothMove = 1f;

    public void Start () {
        targetPos = transform.position;
	}

    public void Update () {

        transform.position = Vector3.Lerp(transform.position, targetPos, smoothMove * Time.deltaTime);

	}


}
