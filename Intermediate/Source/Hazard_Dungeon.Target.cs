using UnrealBuildTool;

public class Hazard_DungeonTarget : TargetRules
{
	public Hazard_DungeonTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Hazard_Dungeon");
	}
}
