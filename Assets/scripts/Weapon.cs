﻿using UnityEngine;
using System.Collections.Generic;

public enum WeaponType
{
    Hand,
    Axe,
    Pistol
}

public enum WeaponUseState
{
    Idle,
    Use,
    Reload
}

public interface IWeapon
{
    IEventTire GetTire();
    void StartUsing();
    void StopUsing();
    void Recharge();
}

public class WeaponUseStateChangedEvent : TireEvent
{
    public WeaponUseState NewState;

    public WeaponUseStateChangedEvent()
    {
        Type = TireEventType.WeaponUseStateChangedEvent;
    }

}

public class WeaponUseStateDoneEvent : TireEvent
{
    public WeaponState WeaponState;

    public WeaponUseStateDoneEvent()
    {
        Type = TireEventType.WeaponUseStateDoneEvent;
    }

}