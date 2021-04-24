using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int poder;
    public MovementPlayer MovementPlayer;
    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player" )
        {
            MovementPlayer.vida = -poder;
            
                        
        }
    }
}
