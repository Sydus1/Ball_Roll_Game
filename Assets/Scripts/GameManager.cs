using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    
    public TMP_Text collectiblesNumbersText;
    public TMP_Text totalCollectiblesNumbersText;

    private int collectiblesNumber;
    private int totalCollectiblesNumber;

    private void Start()
    {
        totalCollectiblesNumber= transform.childCount;
        totalCollectiblesNumbersText.text = totalCollectiblesNumber.ToString();
    }

    public void AddCollectible()
    {
        collectiblesNumber++;

        collectiblesNumbersText.text = collectiblesNumber.ToString();

        audioSource.Play();

    }


    private void Update()
    {
        if (transform.childCount <= 0) 
        {
            Debug.Log("Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
