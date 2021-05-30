using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomSkip : MonoBehaviour
{

    ListPickup inventario;
    public int iteracion;
    public void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ListPickup>();
    }
    public void Update()
    {
        if(transform.childCount <= iteracion)
        {
            inventario.isFull[iteracion] = false;
        }
    }
    public void Skip()
    {
        foreach (Transform item in transform)
        {
           
            GameObject.Destroy(item.gameObject);
        }
    }
}
