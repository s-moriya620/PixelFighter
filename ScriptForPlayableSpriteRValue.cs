using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScriptForPlayableSpriteRValue : MonoBehaviour
{
    public TMP_Text ShowingRValue;
    void Start()
    {
        int R = PlayableSpriteController.RValue;
        ShowingRValue.text = R.ToString();
    }
}
