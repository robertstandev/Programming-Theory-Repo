using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public abstract class Animal : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField]private float speed = 1f;
    protected Vector3 startPosition;
    protected Vector3 movePosition;
    protected bool isMove = false;

    private float startTime;
    private float distanceLength;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {

    }

    public virtual void Action(Button btn)
    {
        btn.interactable = false;

        startTime = Time.time;
        distanceLength = Vector3.Distance(startPosition, movePosition);
    }
}
