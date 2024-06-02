using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScriptForPlayableSpriteBValue : MonoBehaviour
{
    public TMP_Text ShowingBValue;
    void Start()
    {
        int B = PlayableSpriteController.BValue;
        ShowingBValue.text = B.ToString();
    }
}
