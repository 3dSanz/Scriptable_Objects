using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2D;
    Text translationText;
    public TranslationData translationData;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        translationText = GameObject.Find("ImagenTraduccion").GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*5, rb2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ingles")
        {
            translationText.text = translationData.englishTranslation;
        }

        if (other.gameObject.tag == "Espanol")
        {
            translationText.text = translationData.spanishTranslation;
        }

        if (other.gameObject.tag == "Catalan")
        {
            translationText.text = translationData.catalanTranslation;
        }

    }
}
