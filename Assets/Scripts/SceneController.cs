using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    private GCWTimer _timer = new GCWTimer();

    private void Start()
    {
        _timer.AddTimeActionLinstener(OnTimeSecondListener);
        

    
    }

    private void OnTimeSecondListener(int second)
    {
        if (second == 5)
        {
            SceneManager.LoadScene("GCWCard");
        }
    }

    void Update()
    {
        _timer.Update();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GCWCard");

        }
    }
}
