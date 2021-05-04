using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int poder;
    
    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player" )
        {
            GameManager.GetIns().MovementPlayer.vida -= poder ;
            

        }
    }
}
