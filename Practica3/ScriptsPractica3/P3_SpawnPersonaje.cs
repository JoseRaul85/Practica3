using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_SpawnPersonaje : MonoBehaviour
{
    [SerializeField] Transform origenPersonaje;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            transform.position = origenPersonaje.transform.position;
        }
        
    }

}
