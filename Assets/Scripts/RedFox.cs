using UnityEngine;
using UnityEngine.UI;

//INHERITANCE
public class RedFox : Animal
{
    //POLYMORPHISM
    public override void Action(Button btn)
    {
        movePosition = startPosition + Vector3.right;
        isMove = true;

        base.Action(btn);
    }
}
