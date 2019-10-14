// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class G2020_M1_CarCombatTarget : TargetRules
{
	public G2020_M1_CarCombatTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("G2020_M1_CarCombat");
	}
}
