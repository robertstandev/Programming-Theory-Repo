using UnityEngine;
using UnityEngine.UI;

//INHERITANCE
public class Bird : Animal
{
    //POLYMORPHISM
    public override void Action(Button btn)
    {
        movePosition = startPosition + Vector3.left;
        isMove = true;
        
        base.Action(btn);
    }
}
