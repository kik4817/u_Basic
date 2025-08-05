using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButtonContainer : MonoBehaviour
{
    // 4���� ��ư�� ���ԵǾ� �ֽ��ϴ�. ����, ���丮��, �ɼ�, ����
    public void ButtonStart()
    {
        //Debug.Log("������ �����մϴ�.");

        SceneManager.LoadScene(1);
    }
    public void ButtonTutorial(GameObject tut)
    {
        //Debug.Log("���丮���� �����մϴ�.");

        tut.SetActive(true);
    }
    public void ButtonOption(GameObject opt)
    {
        //Debug.Log("�ɼ��� Ȯ���մϴ�.");

        opt.SetActive(true);
        
    }
    public void ButtonExit()
    {
        //Debug.Log("������ �����մϴ�.");

        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
