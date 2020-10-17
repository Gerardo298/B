using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prueba : MonoBehaviour
{
    public int Max = 100;
    public int Actual;

    public Camara camara;
    public PruebaA prueba;

    // Start is called before the first frame update
    void Start()
    {
        Actual = 0;
        prueba.SetMaxHealth(Max);
    }

    public void Tarea()
    {
        A();
        TakeDamage(5);
    }

    void TakeDamage(int damage)
    {
        Actual += damage;

        prueba.SetHealth(Actual);
    }

    public void A()
    {
        if(Actual == 100)
        {
            gameObject.SetActive(false);
        }
    }
}
