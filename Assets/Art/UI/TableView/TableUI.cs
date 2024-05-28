using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableUI : MonoBehaviour
{
    public GameObject tableUI;
    public Button btn;
    public Button btnSwitchScene;
    public string SceneName;

    void Start()
    {
        tableUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Open();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Close();
        }
    }
    public void Open()
    {
        tableUI.SetActive(true);
        StartCoroutine(ShowSwitchSceneButtonAfterDelay(5));
    }

    public void Close()
    {
        tableUI.SetActive(false);
        btn.gameObject.SetActive(true);
    }

    public void SwitchScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }
    IEnumerator ShowSwitchSceneButtonAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        btnSwitchScene.gameObject.SetActive(true);
    }

}
