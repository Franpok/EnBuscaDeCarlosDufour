using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class Correcta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void siguienteNivel(int nivel)
    {
        SceneManager.LoadScene(nivel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
