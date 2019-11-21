using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JuegoHistoria : MonoBehaviour
{
    public AudioSource wrong, right;
    public Sprite newSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void correcta(int nivel)
    {
        right.Play();
        SceneManager.LoadScene(nivel);
        //sonido correcto
    }

    public void incorrecta()
    {
        this.GetComponent<Image>().sprite = newSprite;
        wrong.Play();
        //aqui va el sonido
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
