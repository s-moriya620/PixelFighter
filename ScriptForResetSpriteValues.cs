using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForResetSpriteValues : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    PlayableSpriteController.EvoLevel = 0;
    PlayableSpriteController.ChosenColor = 0;
    PlayableSpriteController.RValue = 0;
    PlayableSpriteController.GValue = 0;
    PlayableSpriteController.BValue = 0;
    PlayableSpriteController.EXP = 1000;
    PlayableSpriteController.StepCount = 1000;
    }
}
