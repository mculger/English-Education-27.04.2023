using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [SerializeField]
    GameObject logoImg;


    private void Start()
    {
        OpenLogo();
    }


    void OpenLogo()
    {
        logoImg.GetComponent<CanvasGroup>().DOFade(1, 0.5f); //fade ayar�.   
        logoImg.GetComponent<RectTransform>().DOScale(1, 0.5f); // scale ayar�.
    }

    public void SahneyeGec(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
