// Copyright 2016-2020 TriAxis Games L.L.C. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class RuntimeMeshComponent : ModuleRules
{
    public RuntimeMeshComponent(ReadOnlyTargetRules rules) : base(rules)
    {
        bEnforceIWYU = true;
        bLegacyPublicIncludePaths = false;
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;


        // Setup the pro/community definitions
        PublicDefinitions.Add("RUNTIMEMESHCOMPONENT_PRO=0");
        PublicDefinitions.Add("RUNTIMEMESHCOMPONENT_VERSION=TEXT(\"Community\")");

        // This is to access RayTracing Definitions
        PrivateIncludePaths.Add(Path.Combine(EngineDirectory, "Shaders", "Shared"));

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
            }
            );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "RenderCore",
                "RHI",
                "NavigationSystem",
                "PhysicsCore",
				"DeveloperSettings",		
            }
            );
    }
}