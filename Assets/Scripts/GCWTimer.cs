using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCWTimer
{
    public delegate void TimeCheckAction(int second);

    private TimeCheckAction _timeAction;

    public void AddTimeActionLinstener(TimeCheckAction listener)
    { 
    _timeAction = listener;
    }

    private float _accTime; //���� �ð� üũ��
    public int _accSecond; //���� ��

    public void Update()
    { 
        _accTime += Time.deltaTime;

        if (_accTime >= 1)
        {
            _accSecond++;
            _accTime = 0;

            if (_timeAction != null)
                _timeAction.Invoke(_accSecond);
        }
        
    }

    public GCWTimer()
    {
        _accTime = 0;
    }

}
