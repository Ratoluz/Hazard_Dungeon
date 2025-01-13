using UnrealBuildTool;

public class Hazard_DungeonServerTarget : TargetRules
{
	public Hazard_DungeonServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Hazard_Dungeon");
	}
}
