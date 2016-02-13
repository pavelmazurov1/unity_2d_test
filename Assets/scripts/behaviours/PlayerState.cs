﻿using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour
{

    private IEventTire EventTire;

    private IWeapon _CurrentWeapon;
    public IWeapon CurrentWeapon
    {
        get { return _CurrentWeapon; }
        set
        {
            if (_CurrentWeapon != value)
            {
                _CurrentWeapon = value;
                EventTire.SendEvent(new ChangedCurrentWeapon() { NewCurrentWeapon = value });
            }
        }
    }

    void Awake()
    {
        EventTire = GetComponent<IEventTire>();
    }
}