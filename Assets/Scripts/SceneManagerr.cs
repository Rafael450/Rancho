using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerr : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene("CenaPrincipal");
    }

    public void Quit() {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit(0);
        #endif
    }
    public void BackMenu() {
        SceneManager.LoadScene("StartScene");
    }
    public void tutorial() {
        SceneManager.LoadScene("tutorial");
    }
}
