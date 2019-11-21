using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSonido : MonoBehaviour
{
    private void Start()
    {
        menuPausa.SetActive(false);
    }
  
 
    public GameObject menuPausa;
    public Sprite muted, sonido;
    public GameObject boton;
    // Start is called before the first frame update

    public void iniciarMenu()
    {
     
        menuPausa.SetActive(true);
        Time.timeScale = 0;
       
    }
    
    public void mute()
    {
        AudioListener.pause = !AudioListener.pause;
        if(AudioListener.pause == true)
        {
            boton.GetComponent<Image>().sprite = sonido;
        }
        else
        {
            boton.GetComponent<Image>().sprite = muted;
        }
    }
    public void cerrarMenu()
    {
   
        menuPausa.SetActive(false);
        Time.timeScale = 1;
       
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
}
