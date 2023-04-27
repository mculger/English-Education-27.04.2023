using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class searchAlistirmaManager : MonoBehaviour
{

    [SerializeField]
    GameObject fadeImg;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        fadeImg.GetComponent<CanvasGroup>().DOFade(0, 1f).OnComplete(BaslangicSesiCikar);//fade iþlemi bittikten sonra çalýþtýr demek.
        
    }

    void BaslangicSesiCikar()
    {
        if (audioSource)
        {
            audioSource.Play();
        }
    }

   public void sahneGec(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }
}
