﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customCharacterController : Character
{
    public int maxHP;
    public int damage;
    public float critChance;
    public string chName;

    private Character.BaseStatsCharacter stats = new Character.BaseStatsCharacter(100);
    void Awake()
    {
        stats.team = Game.TeamType.Players;
        stats.maxHP = maxHP;
        stats.damage = damage;
        stats.critChance = critChance;

        this.setName(chName);
    }

    public void setTeamAndInit(Game.TeamType team) {
        stats.team = team;
        this.init(stats);
    }
}
