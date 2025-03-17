// Copyright Epic Games, Inc. All Rights Reserved.

#include "arcade_racerWheelRear.h"
#include "UObject/ConstructorHelpers.h"

Uarcade_racerWheelRear::Uarcade_racerWheelRear()
{
	AxleType = EAxleType::Rear;
	bAffectedByHandbrake = true;
	bAffectedByEngine = true;
}