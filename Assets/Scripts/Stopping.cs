using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stopping : MonoBehaviour
{
    [SerializeField] GameObject _cvm1, _cvm2;
    [SerializeField] GameObject _nextLevelButton;
    [SerializeField] GameObject nextLevelPanel;
    [SerializeField] GameObject _checkList;
    GameObject _player,_enemy;
    

    int _level;

    public static bool _checkListComplete, _homeworkComplete;

    private void Awake()
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemy");
        _checkListComplete = false;
        _level = PlayerPrefs.GetInt("Level", _level);
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _homeworkComplete = true;
            _checkListComplete = true;
            collision.gameObject.GetComponent<Ground>().enabled = true;
            collision.gameObject.GetComponent<RuntoGo>().enabled = false;
            collision.gameObject.GetComponent<Animator>().SetBool("_isSprint", false);
            collision.gameObject.GetComponent<Animator>().Play("Idle");
            collision.gameObject.GetComponent<JoystickController>().enabled = false;
            _enemy.SetActive(false);
            _checkList.SetActive(true);
            _cvm1.SetActive(false);
            _cvm2.SetActive(true);
            StartCoroutine(Wait());
        }
    }

    public void No()
    {
        if (_checkListComplete==true)
        {
            _player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15);
            _player.GetComponent<JoystickController2>().enabled = true;
            nextLevelPanel.SetActive(false);
            
        }
        else
        {

            _level = _level + 1;
            PlayerPrefs.SetInt("Level", _level);
            
            SceneManager.LoadScene(0);
        }
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        _nextLevelButton.SetActive(true);
        
    }

}
