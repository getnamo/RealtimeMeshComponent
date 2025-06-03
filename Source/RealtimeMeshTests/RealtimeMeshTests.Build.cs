// Copyright (c) 2015-2024 TriAxis Games, L.L.C. All Rights Reserved.

using UnrealBuildTool;

public class RealtimeMeshTests : ModuleRules
{
    public RealtimeMeshTests(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bUseUnity = false;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core", 
                "RealtimeMeshComponent",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "RealtimeMeshComponent"
            }
        );
    }
}