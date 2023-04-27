using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchExercisesButtonManager : MonoBehaviour
{
    AudioSource audioSource;

    public bool dogrumu;

    private void Awake()
    {
       audioSource = GetComponent<AudioSource>();
    }

    public void sesCikar()
    {
        if (audioSource) 
        {
            audioSource.Play();
        }

        
    }
}
