using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private TextMeshPro createServerTxt, joinserverTxt;
    [SerializeField] private InputField inputField;
    [SerializeField] private string MyText;


    public void SaveInputText()
    {
        MyText = joinserverTxt.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
