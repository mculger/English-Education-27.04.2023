using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class aileyeNotManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    Text ikiSaniyeBasiliTut;
    [SerializeField]
    Image doldurulacakDaire;

    [SerializeField]
    GameObject aileyenotimg;

    bool butonBasilimi;


    float basiliTutmaSuresi;
    float toplamBasilacakSure=2f;


    public void OnPointerDown(PointerEventData eventData)
    {
        butonBasilimi = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        butonBasilimi=false;
    }

    void Update()
    {
        
        if (butonBasilimi)
        {
            ikiSaniyeBasiliTut.gameObject.SetActive(true);
            
            
            basiliTutmaSuresi += Time.deltaTime;

            if(basiliTutmaSuresi >= toplamBasilacakSure)
            {
                butonBasilimi=!false;
                ikiSaniyeBasiliTut.gameObject.SetActive(false);
                aileyenotimg.gameObject.SetActive(true);

            }



            doldurulacakDaire.fillAmount = basiliTutmaSuresi / toplamBasilacakSure;

        }
        
        if(!butonBasilimi)
        {
            basiliTutmaSuresi -= Time.deltaTime;

            if(basiliTutmaSuresi<=0)
            {
                basiliTutmaSuresi = 0;
            }

            ikiSaniyeBasiliTut.gameObject.SetActive(false);
            doldurulacakDaire.fillAmount = basiliTutmaSuresi / toplamBasilacakSure;


        }


    }
    public void AileyeNotKapat()
    {
        basiliTutmaSuresi = 0;
        butonBasilimi = false;
        aileyenotimg.SetActive(false);
    }



}

