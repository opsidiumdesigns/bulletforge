// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BulletForgeExample54Server : TargetRules
{
	public BulletForgeExample54Server(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		BuildEnvironment = TargetBuildEnvironment.Shared;
		ExtraModuleNames.Add("BulletForgeExample54");
	}
}
