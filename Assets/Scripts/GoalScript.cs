using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    private void OnTriggerEnter(Collider collider)
    {
        GameObject collideWith = collider.gameObject;
        if(collideWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collideWith);
        }
    }
}
