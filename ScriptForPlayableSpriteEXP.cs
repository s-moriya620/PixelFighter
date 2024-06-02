using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScriptForPlayableSpriteEXP : MonoBehaviour
{
    public TMP_Text ShowingEXP;
    void Start()
    {
        int Exp = PlayableSpriteController.EXP;
        ShowingEXP.text = Exp.ToString();
    }
}
