using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Goal")
            GameManager.completedLevel();
    }

}
