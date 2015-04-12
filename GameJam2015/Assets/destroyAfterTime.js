#pragma strict

var counter: int;

function Start () 
{
	counter = 0;
}

function Update () 
{
	if(counter > 100)
	{
		Destroy(gameObject);
	}
	counter++;
}