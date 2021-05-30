using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomPower : MonoBehaviour
{
    public void PowerScale()
    {
        Movimiento.Getinstancepersonaje().personajescale.localScale = new Vector3(2, 2, 2);
        StartCoroutine("Scalenormal");
        Destroy(gameObject,4);
    }
    IEnumerator  Scalenormal()
    {
        yield return new WaitForSeconds(3f);
        Movimiento.Getinstancepersonaje().personajescale.localScale = new Vector3(1, 1, 1);

    }
}
