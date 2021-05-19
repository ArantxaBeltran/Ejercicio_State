using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{   public float velocidad;
    private Rigidbody rb;
    private Animator anim;
    public float ahorizontal;
    public float bvertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("x",ahorizontal);
        anim.SetFloat("z",bvertical);

        if (ahorizontal != 0 || bvertical !=0)
        {
            anim.SetBool("cambioanim",true);
        }

        else 
        {
            anim.SetBool("cambioanim", false);
        }
        if (Input.GetKey(KeyCode.B))
        {
            anim.SetTrigger("dance");
            StartCoroutine("posedinamic");
        }
      
    }
        IEnumerator posedinamic()
        {
            yield return new WaitForSeconds(2f);
        anim.SetTrigger("dinamic");
     
    }

    

    private void FixedUpdate()
    {

        ahorizontal = Input.GetAxis("Horizontal");
        bvertical = Input.GetAxis("Vertical");

        Vector3 movim = new Vector3(ahorizontal, 0f, bvertical);

        rb.AddForce(movim * velocidad);
    }
}
