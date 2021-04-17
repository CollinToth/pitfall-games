using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class VictoryZone : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
                
                StartCoroutine(LoadNextLevel());
            }
        }
        
        IEnumerator LoadNextLevel() {
            yield return new WaitForSeconds(5);
            
            if (SceneManager.GetActiveScene().buildIndex == 2) { // Current level is Deep Forest
                SceneManager.LoadScene(4);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3) { // Current level is Floating City
                SceneManager.LoadScene(0);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4) { // Current level is Forest Town
                SceneManager.LoadScene(3);
            }
        }
    }
}