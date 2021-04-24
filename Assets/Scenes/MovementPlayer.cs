using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    private float movimiento;
    public float speed;
    private Rigidbody rb;
    public   int vida ;
    
  




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Movimiento()
    {
       
        
        
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 movimiento = new Vector3(horizontal, 0f, vertical);
            transform.Translate(movimiento * speed);//es para otorgarle una fuerza constante al vector
  
 



    }
    

        }
