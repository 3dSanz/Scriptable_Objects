using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TranslationData", menuName = "Custom/Translation Data")]
public class TranslationData : ScriptableObject
{
    public string englishTranslation;
    public string spanishTranslation;
    public string catalanTranslation;
    // Agrega m�s idiomas seg�n tus necesidades
}