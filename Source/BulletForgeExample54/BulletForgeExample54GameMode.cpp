// Copyright Epic Games, Inc. All Rights Reserved.

#include "BulletForgeExample54GameMode.h"
#include "BulletForgeExample54Character.h"
#include "UObject/ConstructorHelpers.h"

ABulletForgeExample54GameMode::ABulletForgeExample54GameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPerson/Blueprints/BP_FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

}
