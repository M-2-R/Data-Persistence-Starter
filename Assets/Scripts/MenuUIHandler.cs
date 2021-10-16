using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;

    public void PlayerName()
    {
        MenuManager.Instance.PlayerName = inputField.text;
        
    }


    public void StartNew()
    {
        SceneManager.LoadScene(1);
        
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif

    }

    private void Update()
    {
        PlayerName();
    }


}
