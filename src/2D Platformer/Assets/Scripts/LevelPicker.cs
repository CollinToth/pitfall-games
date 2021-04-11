using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class LevelPicker : MonoBehaviour
{
   public void DeepForest() {
	SceneManager.LoadScene(2); 
}

public void FloatingCity() {
	SceneManager.LoadScene(3); 
}

public void ForestTown() {
	SceneManager.LoadScene(4); 
}

public void Back() {
	SceneManager.LoadScene(0); 
}
}
