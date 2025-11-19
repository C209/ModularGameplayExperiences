// Copyright Chronicler.

using UnrealBuildTool;

public class ModularGameplayExperiences : ModuleRules
{
	public ModularGameplayExperiences(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"CommonGame",
				"CommonInput",
				"CommonLoadingScreen",
				"CommonUser",
				"Core",
				"GameFeatures",
				"GameplayTags",
				"ModularGameplay",
				"ModularGameplayActors",
				"ModularGameplayData",
				"NetCore",
				"UMG"
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"EngineSettings",
				"EnhancedInput",
				"GameplayAbilities",
				"GameplayTags",
				"GameplayMessageRuntime",
				"Slate",
				"SlateCore"
			}
			);

		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
			}
			);
	}
}
