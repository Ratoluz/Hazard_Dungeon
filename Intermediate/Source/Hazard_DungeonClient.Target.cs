using UnrealBuildTool;

public class Hazard_DungeonClientTarget : TargetRules
{
	public Hazard_DungeonClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Hazard_Dungeon");
	}
}
