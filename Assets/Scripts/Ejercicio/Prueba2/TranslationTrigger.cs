using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationTrigger : MonoBehaviour
{
    public TranslationData translationData; // Asigna el ScriptableObject desde el Inspector
    private Text translationText; // Referencia al componente Text en la interfaz de usuario

    private void Start()
    {
        // Encuentra el componente Text en la interfaz de usuario (asegúrate de que exista)
        translationText = FindObjectOfType<Text>();
    }
}