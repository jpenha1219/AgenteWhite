using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class AgenteMovil : MonoBehaviour
{
    public NavMeshAgent agente;
    public GameObject m_name;
    public Transform objetivo;
    public string WinSceneName = "WinScene";
    public string LoseSceneName = "LoseScene";
    string m_SceneToLoad;
    bool GameIsEnding = false;
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(m_name.tag == "White") {        
            if(Input.GetMouseButtonDown(0))
            {
                RaycastHit ray;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out ray))
                {
                    agente.destination = ray.point;
                }
            }
        }
        
        else 
        {
            agente.destination = objetivo.position;
        }

        if (GameIsEnding)
        {
            SceneManager.LoadScene(m_SceneToLoad);
            GameIsEnding = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {


        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Enemy")
        {
            GameIsEnding = true;
            m_SceneToLoad = LoseSceneName;
            Debug.Log("PERDISTE");
        }
        if (collision.gameObject.tag == "Finish")
        {
            GameIsEnding = true;
            m_SceneToLoad = WinSceneName;
            Debug.Log("GANASTE");
        }
    }
}
