using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Incorrecta : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite newSprite; 
    void Start()
    {
        
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
