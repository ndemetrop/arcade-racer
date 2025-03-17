// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "arcade_racerPawn.h"
#include "arcade_racerSportsCar.generated.h"

/**
 *  Sports car wheeled vehicle implementation
 */
UCLASS(abstract)
class ARCADE_RACER_API Aarcade_racerSportsCar : public Aarcade_racerPawn
{
	GENERATED_BODY()
	
public:

	Aarcade_racerSportsCar();
};
