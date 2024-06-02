using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public static class DemoModeController
{
    public static int IsDemoModeOn = 0;
}

public static class TutorialController
{
    public static int HasPreBattleIntroductionShown = 1;
    public static int HasRefreshSpriteIntroductionShown = 1;
}

public class ScriptForIntroduction : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    
    void Start()
    {
        if (DemoModeController.IsDemoModeOn == 1) {
            TutorialController.HasPreBattleIntroductionShown = 1;
            TutorialController.HasRefreshSpriteIntroductionShown = 1;
        } else {
            TutorialController.HasPreBattleIntroductionShown = 0;
            TutorialController.HasRefreshSpriteIntroductionShown = 0;
        }
        textComponent.text = string.Empty;
        startMonologue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void startMonologue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length -1)
        {
            index ++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            SceneManager.LoadScene("02 PlayableSpriteMapIntroductionScene");
        }
    }

}
