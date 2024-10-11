using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P3_Collision : MonoBehaviour
{
    int contador;
    [SerializeField] TextMeshProUGUI txt_contador;
    void Start()
    {
        contador = 0;
    }
    void Update()
    {
        
    }
     private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if(obj.CompareTag("Monedas"))
        {
            Destroy(obj);
            contador++;
            Debug.Log(contador);
            txt_contador.text = contador.ToString();
            
        } 
    }
}
