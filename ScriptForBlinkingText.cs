using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class ScriptForBlinkingText : MonoBehaviour
{
    Text flashingText;
    string textToBlink;
    public float BlinkTime;
 
     void Awake()
    {
        flashingText = GetComponent<Text>();
        textToBlink = flashingText.text;
        BlinkTime = 0.5f;
    }
    void OnEnable()
    {
        
        StartCoroutine(BlinkText());
    }
 
    public IEnumerator BlinkText()
    {
        flashingText.text = string.Empty;
        if (SceneManager.GetActiveScene().name == "00 OpeningScene"){
            yield return new WaitForSeconds(3);
        } else {
            yield return new WaitForSeconds(0.5f);
        }
        while (true)
        {
            flashingText.text = string.Empty;
            yield return new WaitForSeconds(BlinkTime);
            flashingText.text = textToBlink;
            yield return new WaitForSeconds(BlinkTime);
        }
    }
}