using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] TextMeshProUGUI bestScoreText;



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

   public void ResetScore()
    {
        MenuManager.Instance.PlayerBestScore = "";
        MenuManager.Instance.BestScore = 0;
        MenuManager.Instance.SaveScore();
        SceneManager.LoadScene(0);


    }

    public void BestScore()
    {
        bestScoreText.text = $"Best Score : {MenuManager.Instance.PlayerBestScore} : {MenuManager.Instance.BestScore}";
    }

    private void Update()
    {
        PlayerName();
    }

    private void Start()
    {
        BestScore();
    }




}
