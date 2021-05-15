using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Musicc : MonoBehaviour {

    public AudioSource bgm;
    public AudioClip clip;

    public float volume = 0.5f;

    public void Awake()
    { 
        GameObject[] don = GameObject.FindGameObjectsWithTag("bgmusic");
        if(don.Length>1)
        Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);      
    }
}
