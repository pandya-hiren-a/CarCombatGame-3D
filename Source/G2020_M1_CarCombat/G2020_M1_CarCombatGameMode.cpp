// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "G2020_M1_CarCombatGameMode.h"
#include "G2020_M1_CarCombatCharacter.h"
#include "UObject/ConstructorHelpers.h"

AG2020_M1_CarCombatGameMode::AG2020_M1_CarCombatGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
