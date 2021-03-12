using System.Collections;
using System.Collections.Generic;
using Platformer.Core;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player has died.
    /// </summary>
    /// <typeparam name="PlayerDeath"></typeparam>
    public class PlayerDeath : Simulation.Event<PlayerDeath>
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            var player = model.player;
            if (player.health.IsAlive)
            {
                player.health.Die();
                model.virtualCamera.m_Follow = null;
                model.virtualCamera.m_LookAt = null;
                // player.collider.enabled = false;
                player.controlEnabled = false;

                if (player.audioSource && player.ouchAudio)
                    player.audioSource.PlayOneShot(player.ouchAudio);
                player.animator.SetTrigger("hurt");
                player.animator.SetBool("dead", true);
                player.maxSpeed = Random.Range(3.0f, 9.0f); // Set player speed to a random float 3-9 inclusive upon death (def. 3)
                player.jumpTakeOffSpeed = Random.Range(7.0f, 13.0f); // Set player jump height to a random float 7-13 inclusive upon death (def. 7)
                // What other attributes could be randomized on death? Fall speed? Size? Color?
                Simulation.Schedule<PlayerSpawn>(2);
            }
        }
    }
}