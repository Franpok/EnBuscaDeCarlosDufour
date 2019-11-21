using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pista : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        menuPausa.SetActive(false);
     
    }
 
    public GameObject menuPausa;
    public GameObject cuadro;
    public Sprite noPixel;
    // Start is called before the first frame update

    public void iniciarMenu()
    {

        menuPausa.SetActive(true);
        Time.timeScale = 0;

    }

    public void cerrarMenu()
    {

        menuPausa.SetActive(false);
        Time.timeScale = 1;

    }
    public void usarPista()
    {
        cuadro.GetComponent<Image>().sprite = noPixel;
        menuPausa.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
