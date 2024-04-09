using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TranslationData", menuName = "Custom/Translation Data")]
public class TranslationData : ScriptableObject
{
    public string englishTranslation;
    public string spanishTranslation;
    public string catalanTranslation;
    // Agrega más idiomas según tus necesidades
}