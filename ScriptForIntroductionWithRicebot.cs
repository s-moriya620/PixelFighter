using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScriptForIntroductionWithRiceBot : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
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
            if (SceneManager.GetActiveScene().name == "02 PlayableSpriteMapIntroductionScene")
            {
                SceneManager.LoadScene("06 PlayableSpriteMapFirstTimeScene");
            }
            else if (SceneManager.GetActiveScene().name == "03 MainSceneIntroductionScene")
            {
                SceneManager.LoadScene("11 MainScene");
            }
            else if (SceneManager.GetActiveScene().name == "04 PreBattleIntroductionScene")
            {
                SceneManager.LoadScene("12 PreBattleScene");
            }
            else if (SceneManager.GetActiveScene().name == "05 RefreshSpriteIntroductionScene")
            {
                SceneManager.LoadScene("13 PreRefreshSpriteScene");
            }
        }
    }

}
