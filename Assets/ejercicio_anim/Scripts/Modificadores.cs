using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Modificadores : MonoBehaviour
{
    public float speed;
    public GameObject velocidadsprite;
    public Text puntostexto;
    public float puntos_;
    

    public void Start()
    {
        velocidadsprite.SetActive(false);
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                Movimiento.Getinstancepersonaje().velocidad += speed;
                velocidadsprite.SetActive(true);
                
                Destroy(gameObject);

            }
         
            if (Input.GetKeyDown(KeyCode.M))
            {
                Movimiento.Getinstancepersonaje().puntos += puntos_;
                puntostexto.text = "Puntuacion : " + Movimiento.Getinstancepersonaje().puntos;

                Destroy(gameObject);


            }





        }
    }

}
