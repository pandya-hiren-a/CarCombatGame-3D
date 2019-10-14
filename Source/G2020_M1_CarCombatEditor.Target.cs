// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class G2020_M1_CarCombatEditorTarget : TargetRules
{
	public G2020_M1_CarCombatEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("G2020_M1_CarCombat");
	}
}
