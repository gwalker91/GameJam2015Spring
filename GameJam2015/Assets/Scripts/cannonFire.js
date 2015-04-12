#pragma strict

var cannonBall: GameObject;

var counter: int;
var tempVector: Vector3;

function Start () 
{

}

function Update () 
{


    if(counter > 100)
    {
        var clone: GameObject;
        tempVector = gameObject.transform.position;
        tempVector.y += 1.4;
        clone = Instantiate(cannonBall, 
            tempVector,
            gameObject.transform.rotation);
        clone.GetComponent.<Rigidbody>().AddForce(-gameObject.transform.position * 5f, 
                    ForceMode.Impulse);
        counter = 0;
    }

    counter++;
}