/* Copyright (c) 2007 Technicat, LLC */

var power = 3.0;
var powerx = 2.0;

function FixedUpdate () {
	var force:Vector3 = new Vector3(powerx*Input.GetAxis("Mouse X"),
					0,
					power*Input.GetAxis("Mouse Y")
				       );
	GetComponent.<Rigidbody>().AddForce(force);
}

