// Copyright Epic Games, Inc. All Rights Reserved.

#include "arcade_racerWheelFront.h"
#include "UObject/ConstructorHelpers.h"

Uarcade_racerWheelFront::Uarcade_racerWheelFront()
{
	AxleType = EAxleType::Front;
	bAffectedBySteering = true;
	MaxSteerAngle = 40.f;
}