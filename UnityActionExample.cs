//Reference: https://docs.unity3d.com/ScriptReference/Events.UnityAction.html

//Attach this script to a GameObject. Attach a Renderer and Button component to the same GameObject for this example.
//This script will change the Color of the GameObject as well as output messages to the Console saying which function was run by the UnityAction.

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UnityActionExample : MonoBehaviour
{
    Button m_AddButton;
    Renderer m_Renderer;

    private UnityAction m_MyFirstAction;
    float m_MyNumber;

    void Start()
    {
        m_AddButton = GetComponent<Button>();
        m_Renderer = GetComponent<Renderer>();

        m_MyFirstAction += MyFunction;
        m_MyFirstAction += MySecondFunction;
        m_AddButton.onClick.AddListener(m_MyFirstAction);
    }

    void MyFunction()
    {
        m_MyNumber++;
        Debug.Log("First Added : " + m_MyNumber);
    }

    void MySecondFunction()
    {
        m_Renderer.material.color = Color.blue;
        Debug.Log("Second Added");
    }
}