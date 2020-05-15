﻿using System;

namespace Imgeneus.World.Game
{

    /// <summary>
    /// Special interface, that all killable objects must implement.
    /// Killable objects like: players, mobs.
    /// </summary>
    public interface IKillable
    {
        /// <summary>
        /// Unique id inside of a game world.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Current health.
        /// </summary>
        public int CurrentHP { get; }

        /// <summary>
        /// Decreases health and calculates how much damage was done in order to get who was killer later on.
        /// </summary>
        /// <param name="hp">damage hp</param>
        /// <param name="damageMaker">who has made damage</param>
        public void DecreaseHP(int hp, IKiller damageMaker);

        /// <summary>
        /// Current stamina.
        /// </summary>
        public int CurrentSP { get; set; }

        /// <summary>
        /// Current mana.
        /// </summary>
        public int CurrentMP { get; set; }

        /// <summary>
        /// Character or mob or npc, that killed this entity.
        /// </summary>
        public IKiller MyKiller { get; }

        /// <summary>
        /// Event, that is fired, when entity is killed.
        /// </summary>
        event Action<IKillable, IKiller> OnDead;
    }
}
