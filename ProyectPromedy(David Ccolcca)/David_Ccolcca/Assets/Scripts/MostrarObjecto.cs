using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarObjecto : MonoBehaviour
{
    public GameObject objeto;

    public void MostrarObjeto()
    {

        if (objeto.activeSelf == false)

            objeto.SetActive(true);
        else
            objeto.SetActive(false);
    }
}
