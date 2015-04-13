#pragma strict

var speed: float;

var topLeft: GameObject;
var topRight: GameObject;
var bottomLeft: GameObject;
var bottomRight: GameObject;

var moveUp: boolean;
var moveRight: boolean;
var moveDown: boolean;
var moveLeft: boolean;

function Start () 
{

}

function Update () 
{
    if(moveUp)
    {
        moveTowardsObject(topLeft);
    }
    if(moveRight)
    {
        moveTowardsObject(topRight);
    }
    if(moveDown)
    {
        moveTowardsObject(bottomRight);
    }
    if(moveLeft)
    {
        moveTowardsObject(bottomLeft);
    }
}

function moveTowardsObject(target: GameObject)
{
    //var Vector3 targetPosition = (0,0,0);
    var targetPosition = target.transform.position;
    var currentPosition = transform.position;
	
    if((Vector3.Distance(currentPosition, targetPosition)) > 0.1f)
    {
        var directionOfTravel = targetPosition - currentPosition;
        directionOfTravel.Normalize();
		
        transform.Translate((directionOfTravel.x * speed * Time.deltaTime),
			(directionOfTravel.y * speed * Time.deltaTime),
			(directionOfTravel.z * speed * Time.deltaTime),
			Space.World);
    }
    else
    {
        if(moveUp)
        {
            moveUp = false;
            moveRight = true;
        }
        else if(moveRight)
        {
            moveRight = false;
            moveDown = true;
        }
        else if(moveDown)
        {
            moveDown = false;
            moveLeft = true;
        }
        else if(moveLeft)
        {
            moveLeft = false;
            moveUp = true;
        }
    }
	
}
