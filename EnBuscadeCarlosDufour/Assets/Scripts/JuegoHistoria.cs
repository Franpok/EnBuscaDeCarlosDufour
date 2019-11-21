using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JuegoHistoria : MonoBehaviour
{

    public Sprite newSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void correcta(int nivel)
    {
        SceneManager.LoadScene(nivel);
    }

    public void incorrecta()
    {
        this.GetComponent<Image>().sprite = newSprite;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
