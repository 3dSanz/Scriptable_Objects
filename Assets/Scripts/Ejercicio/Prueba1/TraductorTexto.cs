using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class TraductorTexto : MonoBehaviour
{
    public Traducciones traducciones; // Referencia al Scriptable Object

    private Text textoUI; // Referencia al componente TextMeshPro

    private void Start()
    {
        textoUI = GetComponent<Text>();
        // Asigna la primera traducción al objeto de texto
        textoUI.text = traducciones.Traduccion;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //InventoryManager.instance.AddItem(traducciones);
        Destroy(this.gameObject);
    }

}