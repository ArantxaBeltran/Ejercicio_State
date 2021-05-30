using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    ListPickup inventario;
    public GameObject buttompower;

    public void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ListPickup>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < inventario.items_.Length ; i++)
            {
                if (inventario.isFull[i] == false)
            {
                    inventario.isFull[i] = true;
                    Instantiate(buttompower, inventario.items_[i].transform, false);
                    Destroy(gameObject);
                    break;
            }

            }
           
        }
       
    }
}
