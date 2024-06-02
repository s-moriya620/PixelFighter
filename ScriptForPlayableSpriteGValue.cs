using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScriptForPlayableSpriteGValue : MonoBehaviour
{
    public TMP_Text ShowingGValue;
    void Start()
    {
        int G = PlayableSpriteController.GValue;
        ShowingGValue.text = G.ToString();
    }
}
