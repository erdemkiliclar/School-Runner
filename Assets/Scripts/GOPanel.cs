using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOPanel : MonoBehaviour
{
    [SerializeField] GameObject _goPanel;
    GameObject _player;
    public static bool _restart = true;
    GameObject _bag;
    float _goScale;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _goScale = 0.5f;
        _bag = GameObject.FindGameObjectWithTag("Bag");
    }
    

    void FixedUpdate()
    {
        if (_bag.transform.localScale.x <= _goScale && FinishLine._levelComplete==false)
        {
            
            _restart = true;
            _bag.SetActive(false);
            StartCoroutine(Wait());
        }
        
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SaveManager.instance.money -= GemCount.currentCount;
        Time.timeScale = 1;
        _goPanel.SetActive(false);
    }

    
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        _goPanel.SetActive(true);
        _player.GetComponent<Animator>().Play("Idle");
        Time.timeScale = 0;
    }


}
