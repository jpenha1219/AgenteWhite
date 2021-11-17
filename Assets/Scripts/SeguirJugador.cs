using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public GameObject Jugador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Jugador.transform.position + new Vector3(10,110,0);
        transform.position = new Vector3(-31,63,Jugador.transform.position.z);
    }
}
