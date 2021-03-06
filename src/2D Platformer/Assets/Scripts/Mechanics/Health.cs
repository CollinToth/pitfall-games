using System;
using Platformer.Gameplay;
using UnityEngine;
using UnityEngine.UI;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Represebts the current vital statistics of some game entity.
    /// </summary>
    public class Health : MonoBehaviour
    {
        /// <summary>
        /// The maximum hit points for the entity.
        /// </summary>
        public int maxHP = 3;

        /// <summary>
        /// Indicates if the entity should be considered 'alive'.
        /// </summary>
        public bool IsAlive => currentHP > 0;

        int currentHP;

        public Text HealthText;

        public void updateHealthDisplay()
        {
            HealthText.text = "Health: " + currentHP;
        }

        /// <summary>
        /// Increment the HP of the entity.
        /// </summary>
        public void Increment()
        {
            currentHP = Mathf.Clamp(currentHP + 1, 0, maxHP);
            updateHealthDisplay();
        }

        public void setFullHP()
        {
            while (currentHP < maxHP) Increment();
            updateHealthDisplay();
        }

        /// <summary>
        /// Decrement the HP of the entity. Will trigger a HealthIsZero event when
        /// current HP reaches 0.
        /// </summary>
        public void Decrement()
        {
            currentHP--;
            if (currentHP <= 0)
            {
                Core.Simulation.Schedule<PlayerDeath>(0f);
            }
            updateHealthDisplay();
        }

        public void takeDamage(int dmg)
        {
            for(int i = 0; i < dmg; i++)
            {
                Decrement();
            }
            updateHealthDisplay();
        }

        /// <summary>
        /// Decrement the HP of the entitiy until HP reaches 0.
        /// </summary>
        public void Die()
        {
            while (currentHP > 0) Decrement();
            updateHealthDisplay();
        }

        void Awake()
        {
            currentHP = maxHP;
            updateHealthDisplay();
        }
    }
}
