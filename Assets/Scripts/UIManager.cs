using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public TMP_InputField Text;
    private Coroutine coroutine;

    void OnEnable()
    {
        TextEvent.UpdateText += UpdateText;
    }

    void OnDisable()
    {
        TextEvent.UpdateText -= UpdateText;
    }

    private void UpdateText(string s)
    {
        Text.text += "*" + s + "\n";

    }
}
