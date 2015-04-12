#pragma strict

var cannonBall: GameObject;

var counter: int;
var tempVector: Vector3;
var tempQuat: Quaternion;

function Start () 
{

}

function Update () 
{


    if(counter > 100)
    {
        var clone: GameObject;
        tempVector = gameObject.transform.position;
        tempQuat = gameObject.transform.rotation;
        tempVector.y += 1.4;
        tempQuat.y = 100;
        clone = Instantiate(cannonBall, 
            tempVector,
            tempQuat);
        clone.GetComponent.<Rigidbody>().AddForce(-gameObject.transform.position * 1f, 
                    ForceMode.Impulse);
        counter = 0;
    }

    counter++;
}