using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public int score;

    [SerializeField] Text scoreText;
    public GameObject bonusEffect;
    public GameObject camera ;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point")
        {
            Destroy(other.gameObject);
            Instantiate(bonusEffect, transform.position, Quaternion.identity);
            if (ManagerElement.isMulti)
                score += 2;
            else
                score++;
        }

        if (other.gameObject.tag == "Enemy")
        {
            Money.score = score;
            ManagerElement.isMore = false;
            ManagerElement.isMulti = false;
            ManagerElement.isSpeed = false;
            SceneManager.LoadScene(2);
        }

    }


   
        

    

    void Update()
    {
        scoreText.text = score.ToString();
        if(score == 20)
        {
            camera.GetComponent<Camera>().backgroundColor = new Color(0.7924f, 0.5345f, 0.5418f, 0);
        }
    }
}
