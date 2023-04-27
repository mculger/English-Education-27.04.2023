using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchButtonManager : MonoBehaviour
{
    AudioSource m_AudioSource;

    




    void Awake()
    {
       m_AudioSource =GetComponent<AudioSource>();
    }

    


    public void SesCikar()
    {
        if (m_AudioSource)
        {
            m_AudioSource.Play();
        }
    }
}
