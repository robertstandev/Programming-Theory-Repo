using UnityEngine;
using UnityEngine.UI;

//INHERITANCE
public class Chick : Animal
{
    //POLYMORPHISM
    public override void Action(Button btn)
    {
        movePosition = startPosition + Vector3.forward;
        isMove = true;

        base.Action(btn);
    }
}
